using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Windows.Forms;

namespace EasyDB
{
    class Connection
    {
        private static Connection instance;
        ProgramFile ProgramFile = ProgramFile.Instance;
        //SystemVariables SystemVariables = SystemVariables.Instance;
        Configuration config = Configuration.Instance;
        private Hashtable connections;
        private const string KEY = "qlawe781-23adw-42-?23";

        public static Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Connection();
                }
                return instance;
            }
        }

        private Connection()
        {


        }

        public void save(string host, string user, string password, string database, string name)
        {
            if (!File.Exists(config.get("Connection Directory") + @"\" + name + ".xml"))
            {
                string file = config.get("Connection Directory") + @"\" + name + ".xml";
                XmlTextWriter xml = new XmlTextWriter(file, null);

                xml.Formatting = Formatting.Indented;
                xml.WriteStartDocument();
                xml.WriteStartElement("connection");
                xml.WriteElementString("name", Cipher.EncryptString(name, KEY));
                xml.WriteElementString("host", Cipher.EncryptString(host, KEY));
                xml.WriteElementString("user", Cipher.EncryptString(user, KEY));
                xml.WriteElementString("database", Cipher.EncryptString(database, KEY));
                xml.WriteElementString("password", Cipher.EncryptString(password, KEY));
                xml.Close();

            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen anderen Namen aus!", "Verbindung existiert bereits!");
            }
        }

        public Hashtable load(string name)
        {
            Hashtable data = new Hashtable();
            Hashtable connections = this.getConnections();
            foreach (DictionaryEntry connection in connections)
            {
                if (connection.Key.ToString().Contains(name))
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(connection.Key.ToString());
                    XmlNode node = xml.SelectSingleNode("database");
                    XmlElement root = xml.DocumentElement;

                    foreach (XmlNode value in root.ChildNodes)
                    {
                        data.Add(value.Name, Cipher.DecryptString(value.InnerText,KEY));
                    }
                }
            }

            return data;
        }

        public void loadAll()
        {
            ProgramFile.ReadDir(config.get("Connection Directory") + @"\", true, "XML", true);
            this.connections = ProgramFile.GetXMLHashtable();
        }

        public Hashtable getConnections()
        {
            return this.connections;
        }

    }
}
