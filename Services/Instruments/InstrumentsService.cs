using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.Instruments.Models;
using TDAmeritrade.Services.Instruments.Types;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Instruments
{

    public class InstrumentsService : AbstractService, IInstrumentsService
    {
        public InstrumentsService(
            IHttpClient httpClient,
            IHttpRequestMessageService httpRequestMessageService)
                : base(httpClient, httpRequestMessageService)
        {
        }

        public async Task<Fundamental> GetFundamentalAsync(string symbol)
        {
            IDictionary<string,Fundamental> response = await SendServiceCall<IDictionary<string,Fundamental>>(HttpMethod.Get, $"/instruments?symbol={symbol}&projection=fundamental");

            // response = JsonExtensions.parsedSearchResponse(response);
            // response = response.Remove(0, 1);
            // response = response.Remove(response.Length - 1, 1);
            
            //Console.WriteLine(response);

            if(response.Values.Count>0)
            {
                return response[symbol];
            }
            else
            {
                return new Fundamental();
            }
        }

        public async Task<IList<Instrument>> SearchAsync(string searchString, Projection projection)
        {
            //return await SendServiceCallWithEmbeddedAPIkey<IList<InstrumentTop>>(HttpMethod.Get, $"/instruments?symbol={searchString}&projection={ProjectionToString.Value(projection)}");

            IDictionary<string,Instrument> response = await SendServiceCall<IDictionary<string,Instrument>>(HttpMethod.Get, $"/instruments?symbol={searchString}&projection={ProjectionToString.Value(projection)}");

            IList<Instrument> instrumentList = new List<Instrument>();
            foreach(var v in response.Values) instrumentList.Add(v);
            //return Shared.Utilities.JsonConfig.DeserializeObject<IList<Instrument>>(response);
            return instrumentList;
        }

        public async Task<Instrument> GetInstrumentByCUSIPAsync(string cusip)
        {
            IList<Instrument> result = await GetInstrumentByCUSIPasListAsync(cusip);
            if(result.Count == 1) return result[0];
            else return new Instrument{Symbol = cusip + "_NOT_FOUND"};
        }

        protected async Task<IList<Instrument>> GetInstrumentByCUSIPasListAsync(string cusip)
        {
            return await SendServiceCall<IList<Instrument>>(HttpMethod.Get, $"/instruments/{cusip}?");
        }
    }
}