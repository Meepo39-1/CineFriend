using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.InvalidParametersExceptions
{
    internal class InvalidEntityException : Exception
    {
        protected string _message;

        public override string Message
        {
            get { return _message; }
        }

        public InvalidEntityException(string message)
        {
            _message = message;
        }

        public InvalidEntityException() : base()
        {
        }
    }
}
