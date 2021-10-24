using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDAmeritrade.Services.Quotes.Models;

namespace TDAmeritrade.Services.Quotes
{
    public interface IQuotesService
    {
         Task<Equity> GetEquityQuoteAsync(string symbol);
         Task<IList<Equity>> GetEquityQuotesAsync(string[] symbol);
    }
}