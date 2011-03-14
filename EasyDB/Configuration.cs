using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace EasyDB
{
    class Configuration
    {
        Hashtable options = new Hashtable();
        private static Configuration instance = null;

        private Configuration() { }

        public static Configuration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Configuration();
                }
                return instance;
            }
        }

        public void set(string key, string value)
        {
            this.options.Add(key, value);
        }

        public string get(string key)
        {
            string value = null;

            if (options.ContainsKey(key))
            {
                foreach (DictionaryEntry option in options)
                {
                    if (option.Key.Equals(key))
                    {
                        value = option.Value.ToString();
                        break;
                    }
                }
            }
            else
            {
                value = "Konfigurationsschlüssel nicht gefunden!";
            }

            return value;
        }
    }
}
