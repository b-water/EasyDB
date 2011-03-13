using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace EasyDB
{
    /// <summary>
    ///  First if you created a new instance you must set the roaming Directory
    ///  with System.Environment.GetEnvironmentVariable("APPDATA"); afther this you must
    ///  set the folder name for the application. Then you can call the Method createifnotexists
    ///  with the subfolders you want to create.
    /// </summary>
    class Roaming
    {
        // the application folder in the roaming directory
        private string _pathToApplicationFolder = null;
        // the path to the roaming directory
        private string _pathToRoamingDirectory = null;
        // the folder name for the application
        private string _folderName = null;

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

        /// <summary>
        /// creates a folder for the application in
        /// the roaming directory if there is no one.
        /// </summary>
        /// <param name="subFolders">string[] the subfolders to create if the folder does not exist</param>
        /// <returns>string path to application folder in roaming directory</returns>
        public string createIfNotExists(string[] subFolders)
        {
            if (!this.pathToRoamingDirectory.Equals(null))
            {
                string directory = null;

                directory = this.pathToRoamingDirectory + @"\" + this.folderName;

                if(!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    foreach (string folder in subFolders)
                    {
                        Directory.CreateDirectory(directory + @"\" + folder);
                    }
                }

                return directory;
            }
            else
            {
                throw new RoamingException("(#2) : The Path to the Roaming Directory is not set!");
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
    }
}
