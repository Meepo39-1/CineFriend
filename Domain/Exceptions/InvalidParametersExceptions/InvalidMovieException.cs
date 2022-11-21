using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.InvalidParametersExceptions
{
    internal class InvalidMovieException : InvalidEntityException
    {
        string _message;


        public override string Message
        {
            get { return _message; }
        }

        public InvalidMovieException() : base()
        {
            _
             _message = "User Not Found";
        }

        InvalidMovieException(string message) : base(message)
        {

            _message = message;
        }
    }
}
