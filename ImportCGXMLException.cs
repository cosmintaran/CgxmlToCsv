using System;
using System.Runtime.Serialization;

namespace CgxmlToCsv
{
     internal class ImportCGXMLException : Exception
    {
        public ImportCGXMLException()
        {
        }

        public ImportCGXMLException(string message) : base(message)
        {
        }

        public ImportCGXMLException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

 
        protected ImportCGXMLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}