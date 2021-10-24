using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDAmeritrade.Services.OptionChains.Models;
using TDAmeritrade.Services.OptionChains.Types;

namespace TDAmeritrade.Services.OptionChains
{
    public interface IOptionChainsService
    {
        Task<IList<OptionContract>> GetOptionsChainAsync(
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
            OptionType? optionType = null); //Type of contracts to return
    }
}