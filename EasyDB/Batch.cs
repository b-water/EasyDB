using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EasyDB
{
    class Batch
    {
        private static Batch instance;
        
        private string host = null;
        private string user = null;
        private string password = null;
        private string database = null;

        private string batchDirectory = null;
        private string mysqlEXE = null;

        SystemVariables SystemVariables = SystemVariables.Instance;

        /// <summary>
        /// The Constructor
        /// </summary>
        private Batch () 
        {
             this.batchDirectory = SystemVariables.getEasyDBAppDataPath() + @"\batches\";
             this.mysqlEXE = SystemVariables.getMySQLExePath();
             this.clear();
        }

        /// <summary>
        /// Create or returns an Instance
        /// </summary>
        public static Batch Instance
        {
              get 
              {
                 if (instance == null)
                 {
                    instance = new Batch();
                 }
                 return instance;
              }
        }


        public bool create(string sqlFile, string name, int index)
        {
            // the new batch file
            string batchFile = this.batchDirectory + name + ".bat";

            // create the file
            FileInfo fileInfo = new FileInfo(batchFile);

            // write the data into the batch file
            StreamWriter streamWriter = fileInfo.CreateText();
            streamWriter.Write(this.mysqlEXE + string.Format(@" -h {0} -u {1} -p{2} -D {3} < {4}", this.host, this.user, this.password, this.database, sqlFile));
            streamWriter.Close();

            if (!File.Exists(batchFile))
            {
                MessageBox.Show("Die Batch Datei für den SQL Dump \"" + sqlFile + "\" konnte nicht erstellt werden!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void clear()
        {
            string[] batchFiles = Directory.GetFiles(this.batchDirectory);
            foreach (string batch in batchFiles)
            {
                FileInfo fileInfo = new FileInfo(batch);
                fileInfo.Delete();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void setHost(string value)
        {
            this.host = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void setUser(string value)
        {
            this.user = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void setPassword(string value)
        {
            this.password = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void setDatabase(string value)
        {
            this.database = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getHost()
        {
            return this.host;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getUser()
        {
            return this.user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getPassword()
        {
            return this.password;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getDatabase()
        {
            return this.database;
        }
    }
}
