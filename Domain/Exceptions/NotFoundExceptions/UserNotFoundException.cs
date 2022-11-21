using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.NotFoundExceptions
{
    internal class UserNotFoundException : Exception
    {
        string _message;


        public override string Message
        {
            get { return _message; }
        }

        public UserNotFoundException() : base()
        {
            _
             _message = "User Not Found";
        }

        UserNotFoundException(string message) : base(message)
        {

            _message = message;
        }
    }
}
