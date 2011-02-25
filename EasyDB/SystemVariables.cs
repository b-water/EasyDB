using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace EasyDB
{
    class SystemVariables
    {
        private bool foundMySQLExe = false;
        private string appDataPath = "";
        private bool foundEasyDBAppDataPath = false;
        private string EasyDBAppDataPath = "";
        private string mySQLExePath = "";
        private static SystemVariables instance;
        private IDictionary variables = Environment.GetEnvironmentVariables();

        ProgramFile ProgramFile = ProgramFile.Instance;

        

        private SystemVariables() { }

        public static SystemVariables Instance
        {
              get 
              {
                 if (instance == null)
                 {
                     instance = new SystemVariables();
                 }
                 return instance;
              }
        }

        
        public bool init()
        {
            foreach (DictionaryEntry entry in variables)
            {
                // if the mysql.exe exists in the path variable
                if (entry.Key.ToString().Equals("Path"))
                {
                    if (entry.Value.ToString().Contains("mysql.exe"))
                    {
                        this.foundMySQLExe = true;
                        string[] pathVariableEntrys = entry.Value.ToString().Split(new Char[] { ';' });
                        foreach (string pathEntry in pathVariableEntrys)
                        {
                            if (pathEntry.Contains("mysql.exe"))
                            {
                                this.mySQLExePath = pathEntry;
                            }
                        }
                    }
                }

                // if a key equals mysql
                if (entry.Key.ToString().Equals("MySQL"))
                {
                    this.foundMySQLExe = true;
                    this.mySQLExePath = entry.Value.ToString();
                }

                // search for roaming
                if (entry.Key.ToString().Equals("APPDATA"))
                {
                    this.appDataPath = entry.Value.ToString();
                    string[] foundDirs = Directory.GetDirectories(this.appDataPath);
                    foreach (string foundDir in foundDirs)
                    {
                        // save the path to roaming data if found
                        if (foundDir.Equals("EasyDB"))
                        {
                            this.foundEasyDBAppDataPath = true;
                            this.EasyDBAppDataPath = foundDir;
                        }
                    }
                }
            }

            // if no roaming dir is found create one
            if (this.foundEasyDBAppDataPath.Equals(false))
            {
                this.EasyDBAppDataPath = this.appDataPath + "\\EasyDB";
                Directory.CreateDirectory(this.EasyDBAppDataPath);
                Directory.CreateDirectory(this.EasyDBAppDataPath + "\\connections");
                Directory.CreateDirectory(this.EasyDBAppDataPath + "\\debug");
                this.foundEasyDBAppDataPath = true;
            }

            // if not found add the mysql exe to the envoirment variables
            if (this.foundMySQLExe.Equals(false))
            {
                try
                {
                    Environment.SetEnvironmentVariable("MySQL", "C:\\xampp\\mysql\\bin\\mysql.exe");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception:" + e.Message);
                }
            }

            // check if path coud be found
            if (this.foundEasyDBAppDataPath.Equals(false) || this.foundMySQLExe.Equals(false))
            {
                return false;
            }

            return true;
        }

        public bool createAppDataDirectory()
        {
            return true;
        }

        public string getEasyDBAppDataPath()
        {
            return this.EasyDBAppDataPath;
        }

        public string getAppDataPath()
        {
            return this.appDataPath;
        }

        public string getMySQLExePath()
        {
            return this.mySQLExePath;
        }

        public IDictionary getVariables()
        {
            return this.variables;
        }
    }
}
