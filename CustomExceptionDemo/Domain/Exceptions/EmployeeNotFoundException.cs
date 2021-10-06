using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomExceptionDemo.Domain.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException()
        {

        }

        public EmployeeNotFoundException(string message)
            : base(message)
        {

        }

        public EmployeeNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }

        public EmployeeNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {

        }
    }
}
