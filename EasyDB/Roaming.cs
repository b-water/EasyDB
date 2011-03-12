using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace EasyDB
{
    class Roaming
    {
        // the application folder in the roaming directory
        private string _pathToApplicationFolder = null;
        // the path to the roaming directory
        private string _pathToRoamingDirectory = null;
        // the folder name for the application
        private string _folderName = null;


        public Roaming()
        {
            this.pathToRoamingDirectory = System.Environment.GetEnvironmentVariable("APPDATA");
        }

        /// <summary>
        /// Fetches the roaming Directory
        /// and checks if a roaming Directory for the application is set.
        /// If no Directory is set the Method calls create and
        /// it creates a Directory.
        /// </summary>
        /// <returns>The Roaming Directory</returns>
        public string fetch()
        {
            // the path to return
            string directory = null;

            string[] roamingDirectorys = Directory.GetDirectories(this.pathToRoamingDirectory);

            // search for the application roaming directory
            foreach (string dir in roamingDirectorys)
            {
                // save the path to roaming data if found
                if (dir.Equals("Wombat"))
                {
                    directory = dir;
                    break;
                }
            }

            if (directory == null)
            {
                //directory = this.create(roaming, "Wombat");
                //this.create(directory,"connections");
                //this.create(directory,"batches");

                //                Directory.CreateDirectory(this.EasyDBAppDataPath + @"\connections");
                //Directory.CreateDirectory(this.EasyDBAppDataPath + @"\debug");
                //Directory.CreateDirectory(this.EasyDBAppDataPath + @"\batches");
            }

            return directory;
        }

        /// <summary>
        /// Creates a Folder in the Roaming Folder
        /// </summary>
        /// <param name="roaming">The Roaming Directory %APPDATA%</param>
        /// <param name="dir">The Directory the Method shoud create</param>
        /// <returns>The Path to the created Directory</returns>
        public string create(string dir)
        {
            if (!this.roamingDirectory.Equals(null))
            {
                string directory = null;

                directory = this.roamingDirectory + "\\" + dir;
                Directory.CreateDirectory(directory);

                if (directory.Equals(null))
                {
                    throw new RoamingException("(#3) : Directory coud not be applied!");
                }

                return directory;
            }
            else
            {
                throw new RoamingException("(#2) : Roaming Directory or Directory to create is not set!");
            }
        }

        /// <summary>
        /// sets or gets the path to the roaming directory
        /// </summary>
        public string pathToRoamingDirectory
        {
            get 
            {
                return this._pathToRoamingDirectory;
            }
            set
            {
                this._pathToRoamingDirectory = value;
            }
        }

        /// <summary>
        /// sets or creates the Path to the application folder
        /// </summary>
        public string pathToApplicationFolder
        {
            get 
            { 
                return this._pathToApplicationFolder; 
            }
            
            set 
            { 
                this._pathToApplicationFolder = value; 
            }
        }

        /// <summary>
        /// sets or get the folder name for the 
        /// application in the roaming directory
        /// </summary>
        public string folderName
        {
            get
            {
                return this._folderName;
            }

            set
            {
                this._folderName = value;
            }
        }

    }
}
