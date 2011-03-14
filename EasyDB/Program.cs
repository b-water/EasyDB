﻿using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;


using System.Data;
using System.Diagnostics;
using System.IO;

namespace EasyDB
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SystemVariables SystemVariables = SystemVariables.Instance;

            //SystemVariables.init();

            Configuration config = Configuration.Instance;
            config.set("Roaming", System.Environment.GetEnvironmentVariable("APPDATA"));
            config.set("Path", System.Environment.GetEnvironmentVariable("Path"));
            config.set("Application", config.get("Roaming") + @"\EasyDB\");
            config.set("Connection Directory", config.get("Application") + @"connection\");
            config.set("Batch Directory", config.get("Application") + @"batch\");

            string[] subFolders = new String[2];
            subFolders[0] = config.get("Batch Directory");
            subFolders[1] = config.get("Connection Directory");

            Roaming roaming = new Roaming();
            roaming.pathToRoamingDirectory = config.get("Roaming");
            roaming.folderName = "EasyDB";
            config.set("Application Directory",roaming.createIfNotExists(subFolders));

            MySQL mysql = new MySQL();
            if (mysql.searchPathVariable())
            {
                config.set("MySQL", mysql.location);
            }
            else
            {
                MessageBox.Show("Pfad zur mysql.exe wurde nicht in der Path Variable gefunden!");
            }

            //System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("MySQL"), " --user=dbadmin --password=1234 testdb < D:\\dumps\\movie.sql");
            //System.Diagnostics.Process.EnterDebugMode();

            //Process process = new Process();
            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.CreateNoWindow = false;
            //process.StartInfo.FileName = @"C:\xampp\mysql\bin\mysql.exe";
            //process.StartInfo.Arguments = string.Format(@" -h {0} -u {1} -p{2} -D {3} < {4}", "127.0.0.1", "dbadmin", "1234", "dmmmmmeliciousred", " C:\\dr.sql");
            //process.StartInfo.Arguments = String.Format(" -h {0} -u {1} -p{2} -e 'show databases;'", "127.0.0.1", "dbadmin", "1234", "dmmmmmeliciousred");
            //DateTime timestamp = DateTime.Now;
            //timestamp.ToString("yyyy");

            //Console.WriteLine(process.StartInfo.Arguments);
            //process.OutputDataReceived += new DataReceivedEventHandler(delegate(object sender, DataReceivedEventArgs args)
            //{
            //    Console.WriteLine(args.Data);
            //});

            //process.Start();
            //process.BeginOutputReadLine();
            //process.WaitForExit();

            //Process ie = new Process();
            //ie.StartInfo.FileName = "paint.exe";
            //ie.Start();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
