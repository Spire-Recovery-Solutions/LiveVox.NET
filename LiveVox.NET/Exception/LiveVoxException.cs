using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LiveVox.NET.Exception
{
    public class LiveVoxException : System.Exception
    {
        public HttpStatusCode HttpStatusCode { get; }
        public int ErrorCode { get; }
        public string ErrorMessage { get; }

        public LiveVoxException(HttpStatusCode httpStatusCode, int errorCode, string errorMessage)
            : base(errorMessage)
        {
            HttpStatusCode = httpStatusCode;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public LiveVoxException(HttpStatusCode httpStatusCode, int errorCode, string errorMessage, System.Exception innerException = null)
            : base(errorMessage, innerException)
        {
            HttpStatusCode = httpStatusCode;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public override string ToString()
        {
            return $"LiveVoxException: {HttpStatusCode} - {ErrorCode} - {ErrorMessage}\n{StackTrace}";
        }
    }
}
