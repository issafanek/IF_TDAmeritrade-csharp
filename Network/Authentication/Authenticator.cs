using System;
using System.Net;
using System.Timers;
using TDAmeritrade.Shared.Utilities;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace TDAmeritrade.Network.Authentication
{
    public class Authenticator : IAuthenticator
    {
        public Models.EASObject easObject {get;set;}
        static readonly System.Net.Http.HttpClient m_httpHandler = new System.Net.Http.HttpClient();

        protected System.Timers.Timer m_refreshAuthTimer = new System.Timers.Timer();
        protected bool m_timerInitialized = false;

        public Authenticator(string clientID)
        {
            if (string.IsNullOrEmpty(clientID))
            {
                throw new ArgumentException(
                    $"{nameof(Authenticator)} requires parameters {nameof(clientID)} to be populated.");
            }
            client_ID = clientID;

            //read auth file if it exists
            if(System.IO.File.Exists(AuthFilePath) == true)
            {
                easObject = JsonConfig.DeserializeObject<Models.EASObject>(System.IO.File.ReadAllText(AuthFilePath));
            }
            else
            {
                easObject = new Models.EASObject();
            }

            Task.Run(() => this.startOAuthAsync()).Wait();
        }

        public string client_ID {get;}
        public string AuthFilePath {get {return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OAuth.json");}}

        public async Task<bool> writeAuthFileAsync()
        {
            try
            {
                string body = JsonConfig.SerializeObject(easObject);
                await System.IO.File.WriteAllTextAsync(AuthFilePath, body);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + "writeRefreshTokenToFile: " + e.Message);
                return false;
            }
        }

        public void OnRefreshAuthTimerElapsed(Object source, System.Timers.ElapsedEventArgs e)
        {
            Task.Run(() => this.startOAuthAsync()).Wait();
        }

        public async Task<bool> startOAuthAsync()
        {
            try
            {
                /////try to see if we have a working refresh code
                if( await refreshAccessTokenAsync() == true)
                {
                    if(m_timerInitialized == false)
                    {
                        m_refreshAuthTimer.Elapsed += OnRefreshAuthTimerElapsed;
                        m_timerInitialized = true;
                    }
                    return true;
                }
                //Console.WriteLine("LAST RESULT: " + m_lastResult.Result.ToString());
                // if (m_lastResult.Result == true)
                // {
                //     return;
                // }

                //start a window for IFBrowser..
                //m_browserWindow = new Views.IF_BrowserWindow(this);
                //m_browserWindow.Show();







                //HttpResponseMessage response = await m_httpHandler.GetAsync("http://www.contoso.com/");
                //response.EnsureSuccessStatusCode();
                //string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                //string responseBody = await m_httpHandler.GetStringAsync("http://www.google.com");

                //This flow is based on section 1.2 in RFC6749
                //Step 1: Send Authorization Request.. the response will be an Authorization Grant
                //https://auth.tdameritrade.com/auth?response_type=code&redirect_uri=https%3A%2F%2F127.0.0.1&client_id=EXAMPLE%40AMER.OAUTHAP
                string responseType = "code";
                string redirectURI = WebUtility.UrlEncode("http://localhost"); //// call back URL must exactly match the call back URI set in the app created in Ameritrade.
                string clientID = WebUtility.UrlEncode(client_ID);
                string authRequestString = "https://auth.tdameritrade.com/auth?"
                    + "response_type=" + responseType + "&"
                    + "redirect_uri=" + redirectURI + "&"
                    + "client_id=" + clientID + "%40AMER.OAUTHAP";
                Console.WriteLine("Auth Request String (copy and paste in a browser): ");
                Console.WriteLine(authRequestString);
                Console.WriteLine("");

                Console.WriteLine("Paste the redirect url here:");
                string resultURL = Console.ReadLine();




                //Step 2
                //decode the authorization code
                //https://localhost/?code=pAmec6FvopP4nIyRmOel%2BArR4D%2BcI%2FNBwySSo%2BQB7vWMIa7nx98io2CAXqEO6DHiSZbf7j2qoaLj8RWqsrz4VtzBSQyHJ2WDpi0FLdrGEXBYP%2BSItAl%2BDN43ZYwVo8kAAv4JAihRjBkCj0WhvUdsdQI6Lo1oCeaRHsIr0g95FjC6ZxaX0miG7cVtd9BtsEmqbo2ueVFkKLxE043cz1d56QpiXFiRRxnvD75SO%2B1xpAZ40Rx4M0xXjzDjl%2BjBudwwd3gd77GcQcfX59XNuPoJpZu2qxAh9L1%2BpG43EbKfFzmvcLx41yBqEXj7AHyrctEHxAyYgR7OA5LcqxoRqsxAD0SIGfo5hanHGSc8y%2F54fxJjHDAt8weO2ofwtStQivBswWeQC47JrJSCJCuflzuadLAfY6k6wi%2BRbb%2Fr3MBleZUkx%2FzIXJrQLoYSJzr100MQuG4LYrgoVi%2FJHHvlghowDTOhhY0vcy9i38ja4nFPAOTefAfq%2FigZFzveO2OOgixfoYTxkEuNFjVvjfvgNAceSQqnoecaMLXTGzUK7DrzI2xMupNXzUps1z4jSGkoPwCnfj2Lk5%2F4fz%2B96jiMx%2FOWCnXVYAyNmHjTcpPJf3I8F%2Fw7MHRlK706wVBAY8fFQOFkeXd%2F6MGe%2BcLLEXwx%2F7rrLxvAj8Xob2jh1bUQIMajcmNufhl7dygGSNXhn%2FXBvYhU9SVSZ9OhYQgiIPKuonJ4OGXdI4QzCnR9AkA03Pj2eJca4La%2FL%2BBm3eFCH0cwvohJar7H1k5D8S9X0ayQ3qjpSNUES0xRWKObuGamGDWu8bitNGohWXmqw4O2ySSfoJ1jm%2Fje0hN0IC6WZSioSBv%2Bn8Qqg77uh%2BH%2BfR5lsS95uOaTC%2B%2F4QqsB747kh8R9qw7ifi9K4SIbgWw%3D212FD3x19z9sWBHDJACbC00B75E
                string authCode = WebUtility.UrlDecode(resultURL.Replace("https://localhost/?code=", ""));
                Console.WriteLine("Decoded Auth Code = " + authCode);
                //in ameritrade developer website, you need to URL decode the code above since the website encodes it again before passing it.

                //https://auth.tdameritrade.com/auth?response_type=code&redirect_uri=https%3A%2F%2F127.0.0.1&client_id=EXAMPLE%40AMER.OAUTHAP
                //https://api.tdameritrade.com/v1/oauth2/token?grant_type=authorization_code&access_type=offline&code={code}&client_id=EXAMPLE%40AMER.OAUTHAP&redirect_uri=EXAMPLE

                string grantType = "authorization_code";

                string URLforRequest = "https://api.tdameritrade.com/v1/oauth2/token";

                var postParameters = new Dictionary<string, string>();
                postParameters.Add("grant_type", grantType);
                postParameters.Add("refresh_token", "");
                postParameters.Add("access_type", "offline");
                postParameters.Add("code", authCode);
                postParameters.Add("client_id", client_ID + "@AMER.OAUTHAP");
                postParameters.Add("redirect_uri", "http://localhost");


                
                var req = new HttpRequestMessage(HttpMethod.Post, URLforRequest) { Content = new FormUrlEncodedContent(postParameters) };
                var responseBody = await m_httpHandler.SendAsync(req);

                Console.WriteLine(new FormUrlEncodedContent(postParameters).Headers);
                string contentpreview = await (new FormUrlEncodedContent(postParameters).ReadAsStringAsync());
                Console.WriteLine(contentpreview);

                //HttpResponseMessage responseBody = await m_httpHandler.PostAsync(URLforRequest,new StringContent(PostMessage));

                if (responseBody.IsSuccessStatusCode == true)
                {
                    string responseBodyString = await responseBody.Content.ReadAsStringAsync();
                    easObject = JsonConfig.DeserializeObject<Models.EASObject>(responseBodyString);
                    Console.WriteLine(responseBodyString);

                    Console.WriteLine(JsonConfig.SerializeObject(easObject));

                    ////////////// ADD THE AUTHORIZATION CODE TO THE HEADERS OF EVERY HTML REQUEST GOING FORWARD:
                    //m_httpHandler.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", m_authResponse.access_token);

                    // if (m_browserWindow != null)
                    // {
                    //     m_browserWindow.Close();
                    //     m_browserWindow = null;
                    // }
                    await writeAuthFileAsync();
                    //m_lastResult.Result = true;

                    m_refreshAuthTimer.Interval = easObject.expires_in * 1000 - 10;
                    m_refreshAuthTimer.AutoReset = true;
                    m_refreshAuthTimer.Start();
                    return true;
                }
                else
                {
                    m_refreshAuthTimer.Stop();
                    Console.WriteLine("Error: " + responseBody.ReasonPhrase);
                    string responseBodyString = await responseBody.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBodyString);
                    // m_lastResult.Result = false;
                    // if (m_browserWindow != null)
                    // {
                    //     m_browserWindow.Close();
                    //     m_browserWindow = null;
                    // }
                    await startOAuthAsync();
                    return false;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return false;
            }
        }

        /// <summary>
        /// Uses the refresh token to obtain a new access token
        /// </summary>
        async public Task<bool> refreshAccessTokenAsync()
        {
            try
            {
                ////remove authorization from the 
                m_httpHandler.DefaultRequestHeaders.Clear();

                string URLforRequest = Shared.ApiUris.ApiUri + "/oauth2/token";

                var postParameters = new Dictionary<string, string>();
                postParameters.Add("grant_type", "refresh_token");
                postParameters.Add("refresh_token", easObject.refresh_token);
                postParameters.Add("client_id", client_ID + "@AMER.OAUTHAP");

                string contentpreview = await (new FormUrlEncodedContent(postParameters).ReadAsStringAsync());
                Console.WriteLine("SENDING::::");
                Console.WriteLine(contentpreview);

                var req = new HttpRequestMessage(HttpMethod.Post, URLforRequest) { Content = new FormUrlEncodedContent(postParameters) };
                var responseBody = await m_httpHandler.SendAsync(req);

                Console.WriteLine("RECEIVING::::");
                if (responseBody.IsSuccessStatusCode == true)
                {
                    string responseBodyString = await responseBody.Content.ReadAsStringAsync();
                    //m_authResponse = JsonSerializer.Deserialize<IF_TD_EASobject>(responseBodyString);
                    easObject = JsonConfig.DeserializeObject<Models.EASObject>(responseBodyString);
                    // m_authResponse.access_token = newResponse.access_token;
                    // m_authResponse.expires_in = newResponse.expires_in;
                    // m_authResponse.scope = newResponse.scope;
                    // m_authResponse.token_type = newResponse.token_type;
                    Console.WriteLine(JsonConfig.SerializeObject(easObject));

                    //Console.WriteLine(m_authResponse.ToString());

                    ////////////// ADD THE AUTHORIZATION CODE TO THE HEADERS OF EVERY HTML REQUEST GOING FORWARD:
                    //m_httpHandler.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", m_authResponse.access_token);
                    //m_lastResult.Result = true;

                    return true;
                }
                else
                {
                    Console.WriteLine("Error: " + responseBody.ReasonPhrase);
                    string responseBodyString = await responseBody.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBodyString);
                    //m_lastResult.Result = false;

                    return false;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return false;
            }
        }
    }
}