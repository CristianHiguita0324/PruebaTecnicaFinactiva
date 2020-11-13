using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Exception_
{
   public class BusinessException:Exception
    {
        public BusinessException(string message) : base(message)
        {
        }

        public BusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
