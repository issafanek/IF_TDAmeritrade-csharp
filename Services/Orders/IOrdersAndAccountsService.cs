using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDAmeritrade.Services.Orders.Models;
using TDAmeritrade.Services.Orders.Types;

namespace TDAmeritrade.Services.Orders
{
    public interface IOrdersAndAccountsService
    {
        Task<string> CancelOrderAsync(Int64 accountID, Int64 orderID);
        Task<Order> GetOrderAsync(Int64 AccountID, Int64 orderID);
        Task<IList<Order>> GetOrdersByPathAsync(Int64 AccountID, DateTime from, DateTime to, int? maxResults = null, Status status = Status.NOT_DEFINED);
        //returns all orders that fit the criteria for all accounts.
        Task<IList<Order>> GetOrdersByQueryAsync(DateTime from, DateTime to, int? maxResults = null, Status status = Status.NOT_DEFINED);
        Task<string> PlaceOrderAsync(Int64 accountID, Order order);
        Task<string> ReplaceOrderAsync(Int64 accountID, Int64 orderIDtoReplace, Order order);

        //saved order functionality
        Task<string> CreateSavedOrderAsync(Int64 accountID, Order order);
        Task<string> DeleteSavedOrderAsync(Int64 accountID, Int64 savedOrderID);
        Task<Order> GetSavedOrderAsync(Int64 accountID, Int64 savedOrderID);
        Task<IList<Order>> GetSavedOrdersByPathAsync(Int64 accountID);
        Task<string> ReplaceSavedOrderAsync(Int64 accountID, Int64 replacedSavedOrderID, Order order);

        //ACCOUNTS FUNCTIONALITY
         Task<IList<SecuritiesAccount>> GetAccountsAsync(bool includePositions = false, bool includeOrders = false);
         Task<SecuritiesAccount> GetAccountAsync(string acccountID, bool includePositions = false, bool includeOrders = false);
    }
}