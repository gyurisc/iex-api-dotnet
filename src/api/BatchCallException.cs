using System;
using System.Collections.Generic;
using System.Text;

namespace IEXAPI
{
    public class BatchCallException : Exception
    {
        public string Json { get; set; }
        public string[] Symbols { get; set; }
        public string[] Types { get; set; }

        public BatchCallException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
