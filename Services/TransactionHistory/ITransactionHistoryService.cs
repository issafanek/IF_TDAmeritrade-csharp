using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.TransactionHistory.Models;
using TDAmeritrade.Services.TransactionHistory.Types;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.TransactionHistory
{
    public interface ITransactionHistoryService
    {
        Task<IList<Transaction>> GetTransactionsByQueryAsync(string accountID, TransactionType? type = null, string? symbol = null, DateTime? startDate = null, DateTime? fromDate = null);
        Task<Transaction> GetTransactionAsync(string accountID, string transactionID);
    }
}