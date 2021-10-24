using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.MarketHours.Models;
using TDAmeritrade.Services.MarketHours.Types;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.MarketHours
{
    public class MarketHoursService : AbstractService, IMarketHoursService
    {
        public MarketHoursService(
            IHttpClient httpClient,
            IHttpRequestMessageService httpRequestMessageService)
                : base(httpClient, httpRequestMessageService)
        {
        }
        // public async Task<MarketTypeHours> GetMarketHoursAsync(MarketType market, DateTime date)
        // {
        //     if(market != MarketType.EQUITY && market != MarketType.OPTION)
        //     {
        //         throw new NotImplementedException($"GetMarketHoursAsync: {market} is not supported for Market Hours Functionality.");
        //     }

        //     string uri = $"/marketdata/{market.ToString()}/hours?date={date.ToString("yyy-MM-dd")}";
        //     MarketHoursResponse response = await SendServiceCall<MarketHoursResponse>(HttpMethod.Get, uri);
            
        //     Console.WriteLine(Shared.Utilities.JsonConfig.SerializeObject(response));
        //     return response.Hours();
        // }

        // public async Task<AllMarketHours> GetMarketHoursAsync(DateTime date)
        // {
        //     //fetch equity market hours
        //     string uri = $"/marketdata/EQUITY/hours?date={date.ToString("yyy-MM-dd")}";
        //     MarketHoursResponse response = await SendServiceCall<MarketHoursResponse>(HttpMethod.Get, uri);
        //     EquityHours eqHours = (EquityHours)(response.EquityHours);
        //     uri = $"/marketdata/OPTION/hours?date={date.ToString("yyy-MM-dd")}";
        //     response = await SendServiceCall<MarketHoursResponse>(HttpMethod.Get, uri);
        //     OptionsHours opHours = (OptionsHours)(response.OptionHours);
        //     AllMarketHours result = new AllMarketHours(eqHours, opHours);

        //     Console.WriteLine(Shared.Utilities.JsonConfig.SerializeObject(response));
        //     return result;
        // }

        public async Task<IList<Hours>> GetMarketHoursAsync(MarketType marketType, DateTime date)
        {
            //fetch equity market hours
            string uri = $"/marketdata/{marketType.ToString()}/hours?date={date.ToString("yyy-MM-dd")}";
            IDictionary<string, IDictionary<string,Hours>> response = await SendServiceCall<IDictionary<string, IDictionary<string,Hours>>>(HttpMethod.Get, uri);
            //foreach(string k in  response.Keys) Console.WriteLine(k);
            //Console.WriteLine(Shared.Utilities.JsonConfig.SerializeObject(response));

            IList<Hours> result = new List<Hours>();
            foreach(var item in response.Values)
            {
                foreach(var hours in item.Values)
                {
                    result.Add(hours);
                }
            }

            return result;
        }
    }
}