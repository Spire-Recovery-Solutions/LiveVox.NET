using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LiveVox.NET.Models.Error;

namespace LiveVox.NET.Exception
{
    public class LiveVoxException : System.Exception
    {
        public HttpStatusCode HttpStatusCode { get; }
        public ErrorResponse ErrorBody { get; }

        public LiveVoxException(HttpStatusCode httpStatusCode, int errorCode, string errorMessage)
            : base(errorMessage)
        {
            HttpStatusCode = httpStatusCode;
            ErrorBody = new ErrorResponse { Code = errorCode, Message = errorMessage };
        }

        public LiveVoxException(HttpStatusCode httpStatusCode, int errorCode, string errorMessage, System.Exception innerException = null)
            : base(errorMessage, innerException)
        {
            HttpStatusCode = httpStatusCode;
            ErrorBody = new ErrorResponse { Code = errorCode, Message = errorMessage };
        }

        public override string ToString()
        {
            return $"LiveVoxException: {HttpStatusCode} - {ErrorBody.Code} - {ErrorBody.Message}\n{StackTrace}";
        }
    }
}
