using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyDB
{
    public class BatchException : System.Exception
    {
        public BatchException() : base() { }
        public BatchException(string message) : base(message) { }
        public BatchException(string message, System.Exception inner) : base(message, inner) { }

        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client. 
        protected BatchException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }

}
