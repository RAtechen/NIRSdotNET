using System;
using Gtk;
using System.Collections.Generic;
using System.IO;

namespace SNIRFvalidator
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                List<nirs.HDF5info> info = nirs.io.SNIRFinfo(args[0]);
                List<string> invalid = new List<string>();
                bool isvalid = nirs.io.SNIRFValidate(info, ref invalid);

                if (args.Length > 1)
                {
                    // store to file
                    TextWriter tw = new StreamWriter(args[1]);

                    // write a line of text to the file
                    tw.WriteLine("*********   SNIRF Validation   **********");
                    tw.WriteLine(string.Format("File: {0}", args[0]));
                    if (isvalid)
                    {
                        tw.WriteLine("File is VALID");
                    }
                    else
                    {
                        tw.WriteLine("WARNING IS INVALID");
                    }

                    if (invalid.Count > 0)
                    {
                        tw.WriteLine("WARNING Unknown fields found");
                        for (int i = 0; i < invalid.Count; i++)
                        {
                            tw.WriteLine(string.Format("Unknown {0}", invalid[i]));
                        }
                    }

                    tw.WriteLine("-----------------------------------------");
                    for (int i = 0; i < info.Count; i++)
                    {
                        tw.WriteLine(string.Format("{0} [ {1} ]  : {2}\r", info[i].field, info[i].HDFclass, info[i].description));
                    }
                    // close the stream
                    tw.Close();
                }
                else
                {
                    Console.WriteLine("*********   SNIRF Validation   **********");
                    Console.WriteLine(string.Format("File: {0}", args[0]));
                    if (isvalid)
                    {
                        Console.WriteLine("File is VALID");
                    }
                    else
                    {
                        Console.WriteLine("WARNING IS INVALID");
                    }

                    if (invalid.Count > 0)
                    {
                        Console.WriteLine("WARNING Unknown fields found");
                        for(int i=0; i<invalid.Count; i++)
                        {
                            Console.WriteLine(string.Format("Unknown {0}", invalid[i]));
                        }
                    }

                    Console.WriteLine("-----------------------------------------");
                    for (int i = 0; i < info.Count; i++)
                    {
                        Console.WriteLine(string.Format("{0} [ {1} ]  : {2}\r", info[i].field, info[i].HDFclass, info[i].description));
                    }



                }


                return;
            }


            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
