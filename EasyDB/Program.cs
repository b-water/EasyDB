using System;
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
