using System;
using MathNet.Filtering;
using MathNet.Filtering.Kalman;
using System.Collections.Generic;

namespace NIRSrecorder
{

	public struct MBLLmapping {
		public int[][] measurementPairs;
		public int[][] hboIndex;
		public double[][] ExtCoefHbO;
		public double[][] ExtCoefHbR;
		public double[] distances;
	}

	public partial class RealtimeEngine
	{
        public OnlineFilter[][] OnlineFIRFiltersHPF;
		public OnlineFilter[][] OnlineFIRFiltersHPF2;
		public OnlineFilter[][] OnlineFIRFiltersLPF;
		readonly DiscreteKalmanFilter[][] MocoKalman;
        private readonly int[] nsamples;
		public MBLLmapping[] mBLLmappings;


		public RealtimeEngine()
		{

			nsamples = new int[MainClass.devices.Length];

			bool usehpf = MainClass.win._handles.useHPF.Active;
			bool uselpf = MainClass.win._handles.useLPF.Active;

			double hpf;
			usehpf= (usehpf & double.TryParse(MainClass.win._handles.editHPF.Text, out hpf));

			double lpf;
			uselpf = (uselpf & double.TryParse(MainClass.win._handles.editLPF.Text,out lpf));

			double[] fs = new double[MainClass.devices.Length];
			OnlineFIRFiltersHPF = new OnlineFilter[MainClass.devices.Length][];
			OnlineFIRFiltersHPF2 = new OnlineFilter[MainClass.devices.Length][];
			OnlineFIRFiltersLPF = new OnlineFilter[MainClass.devices.Length][];
			MocoKalman = new DiscreteKalmanFilter[MainClass.devices.Length][];

			mBLLmappings = new MBLLmapping[MainClass.devices.Length];

			for (int i = 0; i < MainClass.devices.Length; i++)
			{

				int nSDpairs = MainClass.win.nirsdata[i].probe.numChannels / MainClass.win.nirsdata[i].probe.numWavelengths;

				mBLLmappings[i] = new MBLLmapping();
				mBLLmappings[i].distances = new double[nSDpairs];
				mBLLmappings[i].hboIndex = new int[nSDpairs][];
				mBLLmappings[i].measurementPairs = new int[nSDpairs][];
			
				mBLLmappings[i].ExtCoefHbO = new double[nSDpairs][];
				mBLLmappings[i].ExtCoefHbR = new double[nSDpairs][];

				int cnt = 0;
				int[] cnt2 = new int[nSDpairs];
                for(int ii=0; ii<nSDpairs; ii++) {
                    cnt2[ii] = 0;
					mBLLmappings[i].hboIndex[ii] = new int[2];
					mBLLmappings[i].measurementPairs[ii] = new int[MainClass.win.nirsdata[i].probe.numWavelengths];
					mBLLmappings[i].ExtCoefHbO[ii] = new double[MainClass.win.nirsdata[i].probe.numWavelengths];
					mBLLmappings[i].ExtCoefHbR[ii] = new double[MainClass.win.nirsdata[i].probe.numWavelengths];
				}

				nirs.Media media = new nirs.Media();
				for (int sI=0;sI< MainClass.win.nirsdata[i].probe.numSrc; sI++)
                {
					for (int dI = 0; dI < MainClass.win.nirsdata[i].probe.numDet; dI++)
					{
						bool found = false; ;
						for (int mI = 0; mI < MainClass.win.nirsdata[i].probe.numChannels; mI++)
						{
							if (MainClass.win.nirsdata[i].probe.ChannelMap[mI].sourceindex == sI &
								MainClass.win.nirsdata[i].probe.ChannelMap[mI].detectorindex == dI)
							{
								mBLLmappings[i].measurementPairs[cnt][cnt2[cnt]] = mI + MainClass.win.nirsdata[i].probe.numChannels;
								if (mBLLmappings[i].hboIndex[cnt][0] == 0)
								{

									mBLLmappings[i].hboIndex[cnt][0] = mI + MainClass.win.nirsdata[i].probe.numChannels * 2;
									mBLLmappings[i].hboIndex[cnt][1] = mI + nSDpairs + MainClass.win.nirsdata[i].probe.numChannels * 2;
								}
								
								mBLLmappings[i].distances[cnt] = 0;
								media.GetSpectrum(MainClass.win.nirsdata[i].probe.ChannelMap[mI].wavelength,
									out mBLLmappings[i].ExtCoefHbO[cnt][cnt2[cnt]], out mBLLmappings[i].ExtCoefHbR[cnt][cnt2[cnt]]);

								mBLLmappings[i].distances[cnt] = Math.Sqrt((MainClass.win.nirsdata[i].probe.SrcPos[sI, 0] -
																			MainClass.win.nirsdata[i].probe.DetPos[dI, 0]) *
																			(MainClass.win.nirsdata[i].probe.SrcPos[sI, 0] -
																			MainClass.win.nirsdata[i].probe.DetPos[dI, 0]) +
																			(MainClass.win.nirsdata[i].probe.SrcPos[sI, 1] -
																			MainClass.win.nirsdata[i].probe.DetPos[dI, 1]) *
																			(MainClass.win.nirsdata[i].probe.SrcPos[sI, 1] -
																			MainClass.win.nirsdata[i].probe.DetPos[dI, 1]));
								cnt2[cnt]++;
								found = true;
							}


						}
                        if (found)
                        {
							cnt++;
                        }
					}
				}



				nsamples[i] = 0;
				NIRSDAQ.info info = MainClass.devices[i].GetInfo();
				fs[i] = info.sample_rate;
				OnlineFIRFiltersHPF[i] = new OnlineFilter[MainClass.win.nirsdata[i].probe.numChannels];
				OnlineFIRFiltersLPF[i] = new OnlineFilter[MainClass.win.nirsdata[i].probe.numChannels];
				OnlineFIRFiltersHPF2[i] = new OnlineFilter[MainClass.win.nirsdata[i].probe.numChannels];
				MocoKalman[i] = new DiscreteKalmanFilter[MainClass.win.nirsdata[i].probe.numChannels];

				for (int j = 0; j < MainClass.win.nirsdata[i].probe.numChannels; j++)
				{
					OnlineFIRFiltersLPF[i][j] = OnlineFilter.CreateLowpass(ImpulseResponse.Finite, fs[i], lpf);
					OnlineFIRFiltersHPF[i][j] = OnlineFilter.CreateHighpass(ImpulseResponse.Finite, fs[i], hpf);
					OnlineFIRFiltersHPF2[i][j] = OnlineFilter.CreateHighpass(ImpulseResponse.Finite, fs[i], 0.001);
					
					OnlineFIRFiltersHPF[i][j].Reset();
					OnlineFIRFiltersHPF2[i][j].Reset();
					OnlineFIRFiltersLPF[i][j].Reset();

					int order = 5;
					var x0 = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(order + 1, 1, 0);
					var P0 = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.DenseIdentity(order + 1);

					MocoKalman[i][j] = new DiscreteKalmanFilter(x0, P0);


				}
			}

		}

        public List<nirs.core.Data> UpdateRTengine(List<nirs.core.Data> nirsdata)
		{
			bool useMOCO = MainClass.win._handles.useMOCO.Active;
			bool uselpf = MainClass.win._handles.useLPF.Active;
			bool usehpf = MainClass.win._handles.useHPF.Active;
			int nsamplesNew;


			for (int i = 0; i < nirsdata.Count; i++) { 
				nsamplesNew = nirsdata[i].data[0].Count;
				NIRSDAQ.info info = MainClass.devices[i].GetInfo();
				double fs = info.sample_rate;

				for (int tpt = nsamples[i]; tpt < nsamplesNew; tpt++)
				{

					int nch = nirsdata[i].probe.numChannels;
					for (int j = 0; j < nch; j++)
					{
						// optical density
						double d = -Math.Log(nirsdata[i].data[j][tpt]) + Math.Log(nirsdata[i].data[j][0]);
						d = OnlineFIRFiltersHPF2[i][j].ProcessSample(d);

						if (useMOCO)
						{
							int order = 5;
							if (tpt > order)
							{
								var F = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.DenseIdentity(order + 1);
								var Q = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(order + 1, order + 1, 0);
								var H = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, order + 1);
								var R = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, 1, .001);
								var z = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.Dense(1, 1, d);

								for (int k = 0; k < order; k++)
								{
									H[0, k] = -Math.Log(nirsdata[i].data[j][tpt - k - 1]) + Math.Log(nirsdata[i].data[j][0]);
									//data [1].data [j, i - k - 1];
								}

								MocoKalman[i][j].Predict(F, Q);
								MocoKalman[i][j].Update(z, H, R);

								var ressid = H * MocoKalman[i][j].State;
								d = ressid[0, 0];
							}

						}
						if (uselpf)
						{
							d = OnlineFIRFiltersLPF[i][j].ProcessSample(d)/fs/2;
						}
						else
						{
							_ = OnlineFIRFiltersLPF[i][j].ProcessSample(d);
						}

						if (usehpf)
						{
							d = OnlineFIRFiltersHPF[i][j].ProcessSample(d);
						}
						else
						{
							_ = OnlineFIRFiltersHPF[i][j].ProcessSample(d);
						}

						nirsdata[i].data[j + nch].Add(d);

					}

				}
				// MBLL
				for (int tpt = nsamples[i]; tpt < nsamplesNew; tpt++)
				{
                    for(int ch=0; ch<mBLLmappings[i].distances.Length; ch++)
                    {
						
						double E11 = mBLLmappings[i].ExtCoefHbO[ch][0];
						double E12 = mBLLmappings[i].ExtCoefHbR[ch][0];
						double E21 = mBLLmappings[i].ExtCoefHbO[ch][1];
						double E22 = mBLLmappings[i].ExtCoefHbR[ch][1];
                        double L = mBLLmappings[i].distances[ch];

						double d1 = nirsdata[i].data[mBLLmappings[i].measurementPairs[ch][0]][tpt];
						double d2 = nirsdata[i].data[mBLLmappings[i].measurementPairs[ch][1]][tpt];

						double HbO = 1000000 * 1 / L * (E22 * d1 - E12 * d2) / (E11 * E11 - E12 * E21);
						double HbR = 1000000 * 1 / L * (E21 * d2 - E11 * d1) / (E11 * E11 - E12 * E21);


						nirsdata[i].data[mBLLmappings[i].hboIndex[ch][0]].Add(HbO);
						nirsdata[i].data[mBLLmappings[i].hboIndex[ch][1]].Add(HbR);

					}
				}


					nsamples[i] = nsamplesNew;
			}

            return nirsdata;
        }


	}
}

	 