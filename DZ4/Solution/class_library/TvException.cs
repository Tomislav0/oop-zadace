using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace class_library
{
    public class TvException : Exception
    {
        public string Title { get; private set; }
        public TvException()
        {
        }
        public TvException(string title,string message) : base(message)
        {
            Title = title;
        }
        public TvException(string message) : base(message)
        {
        }

        public TvException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TvException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
