using TDAmeritrade.Shared.Utilities.Extensions;
using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using TDAmeritrade.Exceptions;
using TDAmeritrade.Network.Authentication;
using TDAmeritrade.Shared;
using TDAmeritrade.Shared.Utilities.Clock;

namespace TDAmeritrade.Network.HttpRequest
{
    public class HttpRequestMessageService : IHttpRequestMessageService
    {
        private readonly IAuthenticator authenticator;

        private readonly IClock clock;

        //private readonly bool sandBox;

        public HttpRequestMessageService(
            IAuthenticator authenticator,
            IClock clock)//,
            //bool sandBox)
        {
            this.authenticator = authenticator;
            this.clock = clock;
            //this.sandBox = sandBox;
        }

        public HttpRequestMessage CreateHttpRequestMessage(
            HttpMethod httpMethod,
            string requestUri,
            string contentBody = "")
        {
            // var apiUri = sandBox
            //     ? ApiUris.ApiUriSandbox
            //     : ApiUris.ApiUri;
            var apiUri = ApiUris.ApiUri;
            //Console.WriteLine("api uri: " + apiUri);
            //Console.WriteLine("RequestURI: " + requestUri);
            Console.WriteLine("REACHED HERE");
            Console.WriteLine(new Uri(apiUri + requestUri).ToString());
            var requestMessage = new HttpRequestMessage(httpMethod, new Uri(apiUri + requestUri))
            {
                Content = contentBody == string.Empty
                    ? null
                    : new StringContent(contentBody, Encoding.UTF8, "application/json")
            };

            var timeStamp = clock.GetTime().ToTimeStamp();

            //if (authenticator == null)
            //{
            //    AddHeaders(requestMessage, /*null,*/ timeStamp, false);

            //    return requestMessage;
            //}

            //var signedSignature = authenticator.ComputeSignature(httpMethod, authenticator.UnsignedSignature, timeStamp, requestUri, contentBody);

            AddHeaders(requestMessage, /*signedSignature,*/ timeStamp);//, true);
            return requestMessage;
        }

        private void AddHeaders(
            HttpRequestMessage httpRequestMessage,
            /*string signedSignature,*/
            double timeStamp//,
            /*bool includeAuthentication*/)
        {
            httpRequestMessage.Headers.Add("User-Agent", "TDAmeritradeClient");

            // if (!includeAuthentication)
            // {
            //     return;
            // }

            //TODO...
            httpRequestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authenticator.easObject.access_token);
            // httpRequestMessage.Headers.Add("CB-ACCESS-KEY", authenticator.ApiKey);
            // httpRequestMessage.Headers.Add("CB-ACCESS-TIMESTAMP", timeStamp.ToString("F0", CultureInfo.InvariantCulture));
            // httpRequestMessage.Headers.Add("CB-ACCESS-SIGN", signedSignature);
            // httpRequestMessage.Headers.Add("CB-ACCESS-PASSPHRASE", authenticator.Passphrase);
        }

        public string ApiKey{
            get
            {
                return authenticator.client_ID;
            }
        }
    }
}
