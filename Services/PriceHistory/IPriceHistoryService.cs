using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDAmeritrade.Services.PriceHistory.Models;
using TDAmeritrade.Services.PriceHistory.Types;

namespace TDAmeritrade.Services.PriceHistory
{
    public interface IPriceHistoryService
    {
         Task<CandleList> GetPriceHistoryAsync(
             string symbol,
             int period,
             PeriodType periodType,
             int frequency,
             FrequencyType frequencyType,
             bool needExtendedHoursData);

        Task<CandleList> GetPriceHistoryAsync(
             string symbol,
             DateTime startDate,
             DateTime endDate,
             int frequency,
             FrequencyType frequencyType,
             bool needExtendedHoursData);
    }
}