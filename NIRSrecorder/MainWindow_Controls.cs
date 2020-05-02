﻿using System;
using Gtk;
using NIRSrecorder;
using System.Threading;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using MathNet.Filtering;
using System.Linq;


public partial class MainWindow : Window
{



    private void CheckBatteryWrapper()
    {
        while (true)
        {
            Thread.Sleep(batterychecktime);  // update every 20s
            CheckBattery();

        }
    }







    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }



    protected void ClickedMenuPrefrences(object sender, EventArgs e)
    {
        PrefrencesWindow prefrenceswindow = new PrefrencesWindow();
        prefrenceswindow.Show();
        Application.Run();

    }





    protected void RegisterSubject(object sender, EventArgs e)
    {
        RegisterSubject registerSubject = new RegisterSubject();
        registerSubject.Show();
        Application.Run();


    }

    protected void ExitGUI(object sender, EventArgs e)
    {
        for (int i = 0; i < MainClass.devices.Length; i++)
        {
            MainClass.devices[i].Stop();
            MainClass.devices[i].AllOff();
            MainClass.devices[i].FlushBuffer();
        }

        Destroy();

    }

    protected void AboutDLG(object sender, EventArgs e)
    {
        HelpDLG dlg = new HelpDLG();
        dlg.Show();
        Application.Run();
    }

    protected void HelpDLG(object sender, EventArgs e)
    {
        _ = System.Diagnostics.Process.Start("https://bitbucket.org/huppertt/");
    }




    protected void Changeprobe_view(object sender, EventArgs e)
    {
        drawingarea_SDG.QueueDraw();
        if (HyperscanningViewAction.Active)
        {
            drawingarea_SDG2.QueueDraw();
        }
    }


    protected void SetHyperscanningView(object sender, EventArgs e)
    {
        if (HyperscanningViewAction.Active)
        {
            fixed_device1.Visible = true;
            fixed_device2.Visible = true;
            combobox_device1.Visible = true;
            combobox_device2.Visible = true;
            drawingarea_Data2.Visible = true;
            drawingarea_SDG2.Visible = true;

            fixed_device1.Show();
            fixed_device2.Show();
            combobox_device1.Show();
            combobox_device2.Show();
            drawingarea_Data2.Show();
            drawingarea_SDG2.Show();
        }
        else
        {
            //  fixed_device1.Visible = false;
            fixed_device2.Visible = false;
            // combobox_device1.Visible = false;
            combobox_device2.Visible = false;
            drawingarea_Data2.Visible = false;
            drawingarea_SDG2.Visible = false;

            // fixed_device1.Hide();
            fixed_device2.Hide();
            // combobox_device1.Hide();
            combobox_device2.Hide();
            drawingarea_Data2.Hide();
            drawingarea_SDG2.Hide();
        }

    }

    protected void SetShowSystemMsg(object sender, EventArgs e)
    {
        MainClass.win.settings.DEBUG = ShowSystemMessagingAction.Active;
    }


    protected void RegisterQuickStart(object sender, EventArgs e)
    {

        string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        path = System.IO.Path.Combine(path, "LastSettings.xml");

        // Read the Config.xml file
        XmlDocument doc = new XmlDocument();

        doc.Load(path);
        XmlNodeList elemList;

        elemList = doc.GetElementsByTagName("Investigator");
        string investigator = elemList[0].InnerXml.Trim();
        elemList = doc.GetElementsByTagName("Study");
        string study = elemList[0].InnerXml.Trim();
        elemList = doc.GetElementsByTagName("probefile");
        string probefile = elemList[0].InnerXml.Trim();

        nirs.core.Probe probe = nirs.io.LoadProbe(probefile);
        // Add channels for Optical Density, HbO2, and HbR

        int cnt = probe.ChannelMap.Length;
        nirs.ChannelMap[] ChannelMap = new nirs.ChannelMap[cnt * 2 + 2 * cnt / probe.numWavelengths];
        for (int ii = 0; ii < cnt; ii++)
        {
            ChannelMap[ii] = probe.ChannelMap[ii];
        }
        for (int ii = 0; ii < cnt; ii++)
        {
            ChannelMap[ii + cnt] = probe.ChannelMap[ii];
            ChannelMap[ii + cnt].datasubtype = string.Format("ΔOD {0}nm", ChannelMap[ii].wavelength);
        }
        for (int ii = 0; ii < cnt / probe.numWavelengths; ii++)
        {
            ChannelMap[ii + 2 * cnt] = probe.ChannelMap[ii];
            ChannelMap[ii + 2 * cnt].datasubtype = "HbO2";
        }
        for (int ii = cnt / probe.numWavelengths; ii < cnt; ii++)
        {
            ChannelMap[ii + 2 * cnt] = probe.ChannelMap[ii];
            ChannelMap[ii + 2 * cnt].datasubtype = "Hb";
        }

        probe.ChannelMap = ChannelMap;
        probe.measlistAct = new bool[probe.ChannelMap.Length];
        for (int ii = 0; ii < probe.ChannelMap.Length; ii++)
        {
            probe.measlistAct[ii] = true;
        }
        Gdk.Color[] cmap = new Gdk.Color[probe.ChannelMap.Length];
        for (int ii = 0; ii < probe.numChannels; ii++)
        {
            cmap[ii] = probe.colormap[ii];
            cmap[probe.numChannels + ii] = probe.colormap[ii];
            cmap[probe.numChannels * 2 + ii] = probe.colormap[ii];
        }
        probe.colormap = cmap;

        nirsdata = new List<nirs.core.Data>();

        for (int i = 0; i < MainClass.devices.Length; i++)
        {
            nirs.core.Data data = new nirs.core.Data
            {
                demographics = new nirs.Dictionary()
            };
            data.demographics.set("SubjID", "");
            data.demographics.set("Investigator", investigator);
            data.demographics.set("Study", study);
            data.demographics.set("Gender", "");
            data.demographics.set("Group", "");
            data.demographics.set("Age", "");
            data.demographics.set("Instrument", MainClass.win.settings.SYSTEM);
            data.demographics.set("head_circumference", "");
            data.demographics.set("Technician", "");
            data.demographics.set("comments", "");
            DateTime now = DateTime.Now;
            data.demographics.set("scan_date", now.ToString("F"));
            data.probe = probe.Clone();
            nirsdata.Add(data);
        }



        ListStore ClearList = new ListStore(typeof(string));
        MainClass.win._handles.whichdata.Model = ClearList;

        List<string> datatypes = new List<string>();
        for (int ii = 0; ii < probe.ChannelMap.Length; ii++)
        {
            datatypes.Add(probe.ChannelMap[ii].datasubtype);
        }
        datatypes = datatypes.Distinct().ToList();

        foreach (string s in datatypes)
        {
            MainClass.win._handles.whichdata.AppendText(s);
        }

        MainClass.win._handles.whichdata.Active = 0;

        MainClass.win.EnableControls(true);


        MainClass.win._handles.SDGplot.QueueDraw();



    }

    protected void MarkStim(object sender, EventArgs e)
    {
        if (!MainClass.devices[0].isrunning())
        {
            return;
        }


        double time = nirsdata[0].time[nirsdata[0].time.Count - 1];
        string condname = comboboxentry_stimtype.ActiveText;

        int index = 0;
        bool found = false;
        nirs.Stimulus ev = new nirs.Stimulus(); ;
        for (int i = 0; i < nirsdata[0].stimulus.Count; i++)
        {
            if (nirsdata[0].stimulus[i].name.Equals(condname))
            {
                ev = nirsdata[0].stimulus[i];
                ev.onsets.Add(time);
                ev.amplitude.Add(1);
                ev.duration.Add(1);
                found = true;
                nirsdata[0].stimulus[i] = ev;
                index = i;
            }

        }
        if (!found)
        {
            ev = new nirs.Stimulus
            {
                onsets = new List<double>(),
                duration = new List<double>(),
                amplitude = new List<double>(),
                name = condname
            };
            ev.onsets.Add(time);
            ev.amplitude.Add(1);
            ev.duration.Add(1);
            nirsdata[0].stimulus.Add(ev);
            index = ev.duration.Count;
        }


        MyTreeNode myTreeNode = new MyTreeNode(condname, ev.duration[ev.duration.Count - 1],
            ev.onsets[ev.onsets.Count - 1], ev.amplitude[ev.amplitude.Count - 1], index);
        nodeview_stim.NodeStore.AddNode(myTreeNode);

        label_numstim.Text = string.Format("Marks: {0}", ev.amplitude.Count);
        nodeview_stim.QueueDraw();



    }








    protected void ToggleStim(object sender, EventArgs e)
    {
        if (!MainClass.devices[0].isrunning())
        {
            return;
        }

        if (!togglebutton_stim.Active)
        {
            togglebutton_stim.Label = comboboxentry_stimtype.ActiveText;
        }

        bool found = false;
        double time = nirsdata[0].time[nirsdata[0].time.Count - 1];
        string condname = togglebutton_stim.Label;

        nirs.Stimulus ev;
        for (int i = 0; i < nirsdata[0].stimulus.Count; i++)
        {
            if (nirsdata[0].stimulus[i].name.Equals(condname))
            {
                ev = nirsdata[0].stimulus[i];
                found = true;

                if (!togglebutton_stim.Active)
                {
                    ev.onsets.Add(time);
                    ev.amplitude.Add(1);
                    ev.duration.Add(999);

                    label_numstim.Text = string.Format("Marks: {0}", ev.amplitude.Count);
                }
                else
                {
                    ev.duration[ev.duration.Count - 1] = time - ev.onsets[ev.onsets.Count - 1];
                    int index = ev.duration.Count - 1;
                    MyTreeNode myTreeNode = new MyTreeNode(condname, ev.duration[ev.duration.Count - 1],
                        ev.onsets[ev.onsets.Count - 1], ev.amplitude[ev.amplitude.Count - 1], index);
                    nodeview_stim.NodeStore.AddNode(myTreeNode);
                }
                nirsdata[0].stimulus[i] = ev;

            }

        }
        if (!found)
        {
            if (!togglebutton_stim.Active)
            {
                ev = new nirs.Stimulus
                {
                    onsets = new List<double>(),
                    duration = new List<double>(),
                    amplitude = new List<double>(),
                    name = condname
                };
                ev.onsets.Add(time);
                ev.amplitude.Add(1);
                ev.duration.Add(999);
                nirsdata[0].stimulus.Add(ev);
                label_numstim.Text = string.Format("Marks: {0}", ev.amplitude.Count);
            }
        }





    }

    private void EditStimTable(object sender, Gtk.EditedArgs args)
    {
        Gtk.CellRendererText cellRenderer = (Gtk.CellRendererText)sender;
        MyTreeNode nodeStore = nodeview_stim.NodeStore.GetNode(new TreePath(args.Path)) as MyTreeNode;
        //args.Path
        return;
        //   editableCell.Edited += (object o, Gtk.EditedArgs args) => {
        //       var node = store.GetNode(new Gtk.TreePath(args.Path)) as MyTreeNode;
        //       node.Text = args.NewText;
    }


    public void DebugMessage(string msg)
    {
        if (settings.DEBUG)
        {
            textview_debug.Buffer.Text = textview_debug.Buffer.Text + (char)13 + msg;
        }
    }



    protected void ReloadData(object sender, EventArgs e)
    {
    }

    protected void ChangeViewDisplay(object sender, EventArgs e)
    {
    }


    protected void Change_probeview(object sender, EventArgs e)
    {
    }
}



