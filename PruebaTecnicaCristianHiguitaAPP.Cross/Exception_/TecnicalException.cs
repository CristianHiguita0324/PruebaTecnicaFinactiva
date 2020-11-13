using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Exception_
{
    [Serializable]
  public  class TecnicalException : Exception
    {
        public TecnicalException(string message) : base(message)
        {
        }

        public TecnicalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TecnicalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
