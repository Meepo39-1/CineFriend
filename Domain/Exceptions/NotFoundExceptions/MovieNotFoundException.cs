using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.NotFoundExceptions
{
    internal class MovieNotFoundException : Exception
    {
        protected string _message;


        public MovieNotFoundException(string message)
        {
            _message = message;
        }
        public MovieNotFoundException(): base()
        {
            _message = "Movie not found";
        }
    }
}
