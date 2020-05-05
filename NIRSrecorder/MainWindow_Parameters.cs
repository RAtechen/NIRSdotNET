﻿using Gtk;
using NIRSrecorder;
using System.Threading;
using System.Collections.Generic;



public partial class MainWindow : Window
{
    public Handles _handles;
    public NIRSrecorder.Settings settings;
    public List<nirs.core.Data> nirsdata;
    public RealtimeEngine realtimeEngine;
    public static Thread maindisplaythread;  // Timing thread to handle drawing during running aquistion
    public static Thread batteryCheck;

    public int scancount;

    private int batterychecktime = 20000;  // msec interval to check battery


}