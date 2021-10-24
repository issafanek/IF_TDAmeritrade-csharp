using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDAmeritrade.Services.MarketHours.Models;
using TDAmeritrade.Services.MarketHours.Types;

namespace TDAmeritrade.Services.MarketHours
{
    public interface IMarketHoursService
    {
        //Task<MarketTypeHours> GetMarketHoursAsync(MarketType market, DateTime date);
        //Task<IList<Session>> GetMarketHoursAsync(DateTime date);

        Task<IList<Hours>> GetMarketHoursAsync(MarketType marketType, DateTime date);
    }
}