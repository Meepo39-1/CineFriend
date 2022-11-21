using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.FailedException
{
    public class FailedUploadException : Exception
    {
        protected string _message;

        public FailedUploadException(string message)
        {
            _message = message;
        }   
        public FailedUploadException(): base()
        {
            _message = "Failed to upload resource";
        }
    }
}
