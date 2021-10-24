using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.OptionChains.Models;
using TDAmeritrade.Services.OptionChains.Types;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.OptionChains
{

    public class OptionChainsService : AbstractService, IOptionChainsService
    {
        public OptionChainsService(
            IHttpClient httpClient,
            IHttpRequestMessageService httpRequestMessageService)
                : base(httpClient, httpRequestMessageService)
        {
        }

        public async Task<IList<OptionContract>> GetOptionsChainAsync(
            string symbol, 
            ContractTypeFilter? contractType = null, //Type of contracts to return in the chain. Can be CALL, PUT, or ALL. Default is ALL.
            Int64? strikeCount = null, //The number of strikes to return above and below the at-the-money price.
            bool? includeQuotes = null, //Include quotes for options in the option chain. Can be TRUE or FALSE. Default is FALSE.
            StrategyType? strategy = null, //Passing a value returns a Strategy Chain. Possible values are SINGLE, ANALYTICAL (allows use of the volatility, underlyingPrice, interestRate, and daysToExpiration params to calculate theoretical values), COVERED, VERTICAL, CALENDAR, STRANGLE, STRADDLE, BUTTERFLY, CONDOR, DIAGONAL, COLLAR, or ROLL. Default is SINGLE.
            decimal? interval = null, //Strike interval for spread strategy chains (see strategy param).
            decimal? strikePrice = null, //Provide a strike price to return options only at that strike price.
            RangeType? range = null, //Returns options for the given range
            DateTime? fromDate = null, //Only return expirations after this date. For strategies, expiration refers to the nearest term expiration in the strategy.
            DateTime? toDate = null, //Only return expirations before this date. For strategies, expiration refers to the nearest term expiration in the strategy. 
            decimal? volatility = null, //Volatility to use in calculations. Applies only to ANALYTICAL strategy chains (see strategy param).
            decimal? underlyingPrice = null, //Underlying price to use in calculations. Applies only to ANALYTICAL strategy chains (see strategy param).
            decimal? interestRate = null, //Interest rate to use in calculations. Applies only to ANALYTICAL strategy chains (see strategy param).
            Int64? daysToExpiration = null, //Days to expiration to use in calculations. Applies only to ANALYTICAL strategy chains (see strategy param).
            ExpiryMonth? expMonth = null, //Return only options expiring in the specified month
            OptionType? optionType = null ////Type of contracts to return
            ) 
        {
            string uri = $"/marketdata/chains?symbol={symbol.ToUpper()}";
            if(contractType != null) uri += $"&contractType={contractType.ToString()}";
            if(strikeCount != null) uri += $"&strikeCount={strikeCount}";
            if(includeQuotes != null) uri += $"&includeQuotes={includeQuotes}";
            if(strategy != null) uri += $"&strategy={strategy.ToString()}";
            if(interval != null) uri += $"&interval={interval}";
            if(strikePrice != null) uri += $"&strike={strikePrice}";
            if(range != null) uri += $"&range={range.ToString()}";
            if(fromDate != null) uri += $"&fromDate={((DateTime)fromDate).ToString("yyyy-MM-dd")}";
            if(toDate != null) uri += $"&toDate={((DateTime)toDate).ToString("yyyy-MM-dd")}";
            if(volatility != null) uri += $"&volatility={volatility}";
            if(underlyingPrice != null) uri += $"&underlyingPrice={underlyingPrice}";
            if(interestRate != null) uri += $"&interestRate={interestRate}";
            if(daysToExpiration != null) uri += $"&daysToExpiration={daysToExpiration}";
            if(expMonth != null) uri += $"&expMonth={expMonth}";
            if(optionType != null) uri += $"&optionType={optionType.ToString()}";

            OptionChain chainObject = await SendServiceCall<OptionChain>(HttpMethod.Get, uri);
            //Console.WriteLine(Shared.Utilities.JsonConfig.SerializeObject(chainObject));
            IList<OptionContract> result = new List<OptionContract>();
            if(chainObject.PutExpDateMap != null)
            {
                foreach(var item in chainObject.PutExpDateMap.Values)
                {
                    foreach(var optionList in item.Values)
                    {
                        foreach (var optionContract in optionList)
                        {
                            result.Add(optionContract);
                        }
                    }
                }
            }
            if(chainObject.CallExpDateMap != null)
            {
                foreach(var item in chainObject.CallExpDateMap.Values)
                {
                    foreach(var optionList in item.Values)
                    {
                        foreach (var optionContract in optionList)
                        {
                            result.Add(optionContract);
                        }
                    }
                }
            }

            return result;
        }
    }
}