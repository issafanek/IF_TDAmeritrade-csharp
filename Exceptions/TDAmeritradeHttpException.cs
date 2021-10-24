using System;
using System.Net;
using System.Net.Http;
using TDAmeritrade.Services;

namespace TDAmeritrade.Exceptions
{
    public class TDAmeritradeHttpException : HttpRequestException
    {
        public HttpStatusCode StatusCode { get; set; }

        public IEndPoint EndPoint { get; set; }

        public HttpRequestMessage RequestMessage { get; set; }

        public HttpResponseMessage ResponseMessage { get; set; }

        public TDAmeritradeHttpException()
        {
        }

        public TDAmeritradeHttpException(string message) 
            : base(message)
        {
        }

        public TDAmeritradeHttpException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}
