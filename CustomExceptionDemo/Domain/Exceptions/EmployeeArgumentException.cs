using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomExceptionDemo.Domain.Exceptions
{
    public class EmployeeArgumentException : Exception
    {
        public EmployeeArgumentException()
        {

        }

        public EmployeeArgumentException(string message)
            : base(message)
        {

        }

        public EmployeeArgumentException(string message, Exception inner)
            : base (message, inner)
        {

        }

        public EmployeeArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base (info, context)
        {

        }
    }
}
