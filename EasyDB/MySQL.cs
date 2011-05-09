using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyDB
{
    class MySQL
    {
        // der pfad zur mysql.exe
        private string _location = null;
        Configuration config = Configuration.Instance;

        /// <summary>
        /// Sucht innerhalb der Path Variable
        /// nach der mysql.exe
        /// </summary>
        /// <returns>bool gefunden oder nicht</returns>
        public bool searchPathVariable()
        {
            bool found = false;
            if (config.get("Path").Contains("mysql.exe"))
            {
                found = true;
                string[] pathVariableEntrys = config.get("Path").Split(new Char[] { ';' });
                foreach (string pathEntry in pathVariableEntrys)
                {
                    if (pathEntry.Contains("mysql.exe"))
                    {
                        this._location = pathEntry;
                    }
                }
            }

            return found;
        }

        /// <summary>
        /// setzt oder gibt den pfad zur mysql.exe zurück
        /// </summary>
        public string location
        {
            get
            {
                return this._location;
            }

            set
            {
                this._location = value;
            }
        }

    }
}
