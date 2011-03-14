using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace EasyDB
{
    class Batch
    {
        // the instance
        
        // mysql database configuration
        private string _host = null;
        private string _user = null;
        private string _password = null;
        private string _database = null;

        // batch folder in roaming directory
        private string _batchDirectory = null;
        // the mysql exe
        private string _mysql = null;


        /// <summary>
        /// The Constructor
        /// </summary>
        public Batch () 
        {
            // alle bisherigen batch dateien löschen
             string[] batchFiles = Directory.GetFiles(this.batchDirectory);
             foreach (string batch in batchFiles)
             {
                 File.Delete(batch);
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
            streamWriter.Write(this.mysql + string.Format(@" -h {0} -u {1} -p{2} -D {3} < {4}", this.host, this.user, this.password, this.database, sqlFile));
            streamWriter.Close();

            if (!File.Exists(batchFile))
            {
                throw new BatchException("(#1) : Coud not create Batch File!");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Setzt oder gibt den Pfad zur mysql.exe zurück
        /// </summary>
        public string mysql
        {
            get
            {
                return this._mysql;
            }

            set
            {
                this._mysql = value;
            }
        }

        /// <summary>
        /// setzt oder gibt den Pfad für den Ordner der Batches zurück
        /// </summary>
        public string batchDirectory
        {
            get
            {
                return this._batchDirectory;
            }

            set
            {
                this._batchDirectory = value;
            }
        }


        /// <summary>
        /// sets or returns the host
        /// </summary>
        public string host
        {
            get
            {
                return this._host;
            }

            set
            {
                this._host = value;
            }
        }

        /// <summary>
        /// sets or returns the user
        /// </summary>
        public string user
        {
            get
            {
                return this._user;
            }

            set
            {
                this._user = value;
            }
        }

        /// <summary>
        /// sets or returns the password
        /// </summary>
        public string password
        {
            get
            {
                return this._password;
            }

            set
            {
                this._password = value;
            }
        }

        /// <summary>
        /// sets or retuns the database
        /// </summary>
        public string database
        {
            get
            {
                return this._database;
            }

            set
            {
                this._database = value;
            }
        }

    }
}
