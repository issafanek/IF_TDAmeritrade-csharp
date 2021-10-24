using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.TransactionHistory.Models;
using TDAmeritrade.Services.TransactionHistory.Types;
using TDAmeritrade.Shared.Utilities.Extensions;
using TDAmeritrade.Shared.Utilities.Queries;

namespace TDAmeritrade.Services.TransactionHistory
{
    public class TransactionHistoryService : AbstractService, ITransactionHistoryService
    {
        //private readonly QueryBuilder queryBuilder;

        public TransactionHistoryService(
            IHttpClient httpClient,
            IHttpRequestMessageService httpRequestMessageService)//,
            //QueryBuilder queryBuilder)
                : base(httpClient, httpRequestMessageService)
        {
            //this.queryBuilder = queryBuilder;
        }

        public async Task<IList<Transaction>> GetTransactionsByQueryAsync(
            string accountID, 
            TransactionType? type = null, 
            string? symbol = null, 
            DateTime? startDate = null, 
            DateTime? endDate = null)
            {
                string uri = $"/accounts/{accountID}/transactions?";//fromEnteredTime={from.ToString("yyy-MM-dd")}&toEnteredTime={to.ToString("yyyy-MM-dd")}";
                if(type != null)
                {
                    uri += $"type={type.ToString()}";
                }
                else
                {
                    uri += $"type={TransactionType.ALL}";
                }
                if(symbol != null && String.IsNullOrEmpty(symbol) == false)
                {
                    uri += $"&symbol={symbol}";
                }
                if(startDate != null)
                {
                    uri += $"&startDate={((DateTime)startDate).ToString("yyyy-MM-dd")}";
                    if(endDate != null)
                    {
                        uri += $"&endDate={((DateTime)endDate).ToString("yyyy-MM-dd")}";
                    }
                }
                
                return await SendServiceCall<IList<Transaction>>(HttpMethod.Get, uri);
            }

        public async Task<Transaction> GetTransactionAsync(string accountID, string transactionID)
        {
            string uri = $"/accounts/{accountID}/transactions/{transactionID}";//fromEnteredTime={from.ToString("yyy-MM-dd")}&toEnteredTime={to.ToString("yyyy-MM-dd")}";

            return await SendServiceCall<Transaction>(HttpMethod.Get, uri);
        }
    }
}