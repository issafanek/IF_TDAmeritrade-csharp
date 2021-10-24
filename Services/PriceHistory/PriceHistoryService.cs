using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.PriceHistory.Models;
using TDAmeritrade.Services.PriceHistory.Types;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.PriceHistory
{

    public class PriceHistoryService : AbstractService, IPriceHistoryService
    {
        public PriceHistoryService(
            IHttpClient httpClient,
            IHttpRequestMessageService httpRequestMessageService)
                : base(httpClient, httpRequestMessageService)
        {
        }

        public async Task<CandleList> GetPriceHistoryAsync(
             string symbol,
             int period,
             PeriodType periodType,
             int frequency,
             FrequencyType frequencyType,
             bool needExtendedHoursData)
        {
            if(isValid(period,periodType,frequencyType) && isValidFrequency(frequency, frequencyType))
            {
                return await SendServiceCall<CandleList>(HttpMethod.Get, $"/marketdata/{symbol.ToUpper()}/pricehistory?periodType={periodType.ToString().ToLower()}&period={period}&frequencytype={frequencyType.ToString().ToLower()}&frequency={frequency}&needextendedHoursData={needExtendedHoursData.ToString().ToLower()}");
            }
            else
            {
                return new CandleList();
            }
        }

        public async Task<CandleList> GetPriceHistoryAsync(
             string symbol,
             DateTime startDate,
             DateTime endDate,
             int frequency,
             FrequencyType frequencyType,
             bool needExtendedHoursData)
        {
            if(isValidFrequency(frequency,frequencyType))
            {
                return await SendServiceCall<CandleList>(HttpMethod.Get, $"/marketdata/{symbol.ToUpper()}/pricehistory?frequencytype={frequencyType.ToString().ToLower()}&frequency={frequency}&startDate={DateExtensions.toEPOCH(startDate)}&endDate={DateExtensions.toEPOCH(endDate)}&needextendedHoursData={needExtendedHoursData.ToString().ToLower()}");
            }
            else
            {
                return new CandleList();
            }
        }

        protected bool isValid(int period, PeriodType periodType, FrequencyType frequencyType)
        {
            //period validation.
            if(periodType==PeriodType.day)
            {
                if(period != 1 && period != 2 && period != 3 && period != 4 && period != 5 && period != 10)//1, 2, 3, 4, 5, 10*
                {
                    throw new Exception($"Period {period} is not valid for {periodType.ToString()}");
                }
                if(frequencyType != FrequencyType.minute)
                {
                    throw new Exception($"FrequencyType {frequencyType.ToString()} is not valid for {periodType.ToString()}");
                }
            }
            else if(periodType==PeriodType.month)
            {
                if(period != 1 && period != 2 && period != 3 && period != 6)//1, 2, 3, 4, 5, 10*
                {
                    throw new Exception($"Period {period} is not valid for {periodType.ToString()}");
                }
                if(frequencyType != FrequencyType.daily && frequencyType != FrequencyType.weekly)
                {
                    throw new Exception($"FrequencyType {frequencyType.ToString()} is not valid for {periodType.ToString()}");
                }
            }
            else if(periodType==PeriodType.year)
            {
                if(period != 1 && period != 2 && period != 3 && period != 5 && period != 10 && period != 15 && period != 20)// 1*, 2, 3, 5, 10, 15, 20
                {
                    throw new Exception($"Period {period} is not valid for {periodType.ToString()}");
                }
                if(frequencyType != FrequencyType.daily && frequencyType != FrequencyType.monthly)
                {
                    throw new Exception($"FrequencyType {frequencyType.ToString()} is not valid for {periodType.ToString()}");
                }
            }
            else if(periodType==PeriodType.ytd)
            {
                if(period != 1)
                {
                    throw new Exception($"Period {period} is not valid for {periodType.ToString()}");
                }
                if(frequencyType != FrequencyType.daily && frequencyType != FrequencyType.weekly)
                {
                    throw new Exception($"FrequencyType {frequencyType.ToString()} is not valid for {periodType.ToString()}");
                }
            }

            return true;
        }

        protected bool isValidFrequency(int frequency, FrequencyType frequencyType)
        {
            //period validation.
            if(frequencyType==FrequencyType.minute)
            {
                if(frequency != 1 && frequency != 5 && frequency != 10 && frequency != 15 && frequency != 30)//1, 2, 3, 4, 5, 10*
                {
                    throw new Exception($"Frequency {frequency} is not valid for {frequencyType.ToString()}");
                }

            }
            else if(frequencyType==FrequencyType.daily || frequencyType==FrequencyType.weekly || frequencyType==FrequencyType.monthly)
            {
                if(frequency != 1)
                {
                    throw new Exception($"Frequency {frequency} is not valid for {frequencyType.ToString()}");
                }
            }
            

            return true;
        }


    }
}