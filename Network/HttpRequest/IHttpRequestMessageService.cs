using System.Net.Http;

namespace TDAmeritrade.Network.HttpRequest
{
    public interface IHttpRequestMessageService
    {
        HttpRequestMessage CreateHttpRequestMessage(
            HttpMethod httpMethod,
            string requestUri,
            string contentBody = "");

        public string ApiKey {get;}
    }
}
