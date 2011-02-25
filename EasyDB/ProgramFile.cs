using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace EasyDB
{
    public class ProgramFile
    {

        private static ProgramFile instance;
        Hashtable SQLFiles = new Hashtable();
        Hashtable XMLFiles = new Hashtable();

        private ProgramFile () {}

        public static ProgramFile Instance
        {
              get 
              {
                 if (instance == null)
                 {
                    instance = new ProgramFile();
                 }
                 return instance;
              }
        }



        public bool ReadDir(string dir, bool validate, string fileType, bool cut)
        {

            if(Directory.Exists(dir))
            {
                this.clear(fileType);
                string[] foundFiles = Directory.GetFiles(dir);

                if (fileType.Equals("SQL"))
                {
                    foreach (string file in foundFiles)
                    {
                        if (validate == true)
                        {

                            if (file.Contains(".sql"))
                            {
                                if (cut == true)
                                {
                                    int needle = file.LastIndexOf("\\");
                                    string cutName = file.Substring(needle + 1);
                                    this.SQLFiles.Add(file, cutName);
                                }
                                else
                                {
                                    this.SQLFiles.Add(file, file);
                                }

                            }
                        }
                    }
                }

                if (fileType.Equals("XML"))
                {
                    foreach (string file in foundFiles)
                    {

                        if (file.Contains(".xml"))
                        {
                            if (cut == true)
                            {
                                int needleSlash = file.LastIndexOf("\\");
                                string cutSlashName = file.Substring(needleSlash + 1);
                                int needlePoint = cutSlashName.LastIndexOf(".");
                                string cutPointName = cutSlashName.Remove(needlePoint);
                                this.XMLFiles.Add(file, cutPointName);
                            }
                            else
                            {
                                this.XMLFiles.Add(file, file);
                            }
                        }
                    }
                }

                return true;
            }
            return false;
        }

        public void clear(string fileType)
        {
            if (fileType.Equals("SQL"))
            {
                if (SQLFiles.Count > 0)
                {
                    SQLFiles.Clear();
                }
            }

            if (fileType.Equals("XML"))
            {
                if (XMLFiles.Count > 0)
                {
                    XMLFiles.Clear();
                }
            }
        }

        public Hashtable GetSQLHashtable()
        {
            return this.SQLFiles;
        }

        public Hashtable GetXMLHashtable()
        {
            return this.XMLFiles;
        }
    }
}
