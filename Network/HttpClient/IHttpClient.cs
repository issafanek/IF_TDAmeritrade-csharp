using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TDAmeritrade.Network.HttpClient
{
    public interface IHttpClient
    {
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken);

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage);

        public Task<string> ReadAsStringAsync(HttpResponseMessage httpRequestMessage);
    }
}
