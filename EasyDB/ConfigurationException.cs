﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyDB
{
    public class ConfigurationException : System.Exception
    {
        public ConfigurationException() : base() { }
        public ConfigurationException(string message) : base(message) { }
        public ConfigurationException(string message, System.Exception inner) : base(message, inner) { }

        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client. 
        protected ConfigurationException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }

}
