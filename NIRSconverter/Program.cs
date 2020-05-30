using System;
using Gtk;

namespace NIRSconverter
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            nirs.core.Data[] data = new nirs.core.Data[1];
            if (args.Length > 0)
            {
                if (args[0].Contains(".nirs"))
                {
                    data[0] = nirs.io.readDOTnirs(args[0]);
                }
                else if (args[0].Contains(".snirf"))
                {

                    data = nirs.io.readSNIRF(args[0]);
                }
                if (args[1].Contains(".nirs"))
                {
                    string fname = args[1].Substring(0, args[1].LastIndexOf("."));
                    if (data.Length > 1)
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            nirs.io.writeDOTnirs(data[i], string.Format("{0}_{1}.nirs", fname, i));
                            
                        }
                        return;
                    }else
                    {
                        nirs.io.writeDOTnirs(data[0], string.Format("{0}.nirs", fname));
                        return;
                    }
                }
                else if (args[1].Contains(".snirf"))
                {
                    nirs.io.writeSNIRF(data, args[1]);
                    return;
                }

                   
            }


            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
