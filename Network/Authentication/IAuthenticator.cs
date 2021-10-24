using System.Net.Http;

namespace TDAmeritrade.Network.Authentication
{
    public interface IAuthenticator
    {
        Models.EASObject easObject {get;set;}
        string client_ID {get;}
    }
}