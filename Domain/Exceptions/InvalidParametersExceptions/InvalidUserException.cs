using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.InvalidParametersExceptions
{
    internal class InvalidUserException : InvalidEntityException
    {
       
        public InvalidUserException(string message) : base(message)
        {
            _message = message;
        }
        public InvalidUserException() : base()
        {
            _message = "User is not valid";
        }

        
    }
}
