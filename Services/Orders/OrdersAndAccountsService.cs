using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.Orders.Models;
using TDAmeritrade.Services.Orders.Types;
using TDAmeritrade.Shared.Utilities.Extensions;

namespace TDAmeritrade.Services.Orders
{

    public class OrdersService : AbstractService, IOrdersAndAccountsService
    {
        public OrdersService(
            IHttpClient httpClient,
            IHttpRequestMessageService httpRequestMessageService)
                : base(httpClient, httpRequestMessageService)
        {
        }

        public async Task<IList<Order>> GetOrdersByPathAsync(Int64 AccountID, DateTime from, DateTime to, int? maxResults = null, Status status = Status.NOT_DEFINED)
        {
            //TODO: the From date should be within 60 days.. check for that.


            string uri = $"/accounts/{AccountID}/orders?fromEnteredTime={from.ToString("yyy-MM-dd")}&toEnteredTime={to.ToString("yyyy-MM-dd")}";
            if(maxResults != null)
            {
                uri += $"&maxResults={maxResults}";
            }
            if(status != Status.NOT_DEFINED)
            {
                uri += $"&status={status.ToString()}";
            }
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);

            // //response = "[" + response.Substring(1,response.Length - 2) + "]";
            // response = JsonExtensions.parsedSearchResponse(response);
            // response = response.Remove(0, 1);
            // response = response.Remove(response.Length - 1, 1);
            
            // //Console.WriteLine(response);

            return Shared.Utilities.JsonConfig.DeserializeObject<IList<Order>>(response);
        }

        public async Task<IList<Order>> GetOrdersByQueryAsync(DateTime from, DateTime to, int? maxResults = null, Status status = Status.NOT_DEFINED)
        {
            //TODO: the From date should be within 60 days.. check for that.


            string uri = $"/orders?fromEnteredTime={from.ToString("yyy-MM-dd")}&toEnteredTime={to.ToString("yyyy-MM-dd")}";
            if(maxResults != null)
            {
                uri += $"&maxResults={maxResults}";
            }
            if(status != Status.NOT_DEFINED)
            {
                uri += $"&status={status.ToString()}";
            }
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);

            return Shared.Utilities.JsonConfig.DeserializeObject<IList<Order>>(response);
        }

        public async Task<Order> GetOrderAsync(Int64 accountID, Int64 orderID)
        {
            string uri = $"/accounts/{accountID}/orders/{orderID}";
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);
            return Shared.Utilities.JsonConfig.DeserializeObject<Order>(response);
        }

        public async Task<string> PlaceOrderAsync(Int64 AccountID, Order order)
        {
            string orderJson = Shared.Utilities.JsonConfig.SerializeObject(order);

            return await SendServiceCall<string>(
                HttpMethod.Post,
                $"/accounts/{AccountID}/orders",
                orderJson);
        }

        public async Task<string> ReplaceOrderAsync(Int64 AccountID, Int64 orderIDtoReplace, Order order)
        {
            string orderJson = Shared.Utilities.JsonConfig.SerializeObject(order);

            return await SendServiceCall<string>(
                HttpMethod.Put,
                $"/accounts/{AccountID}/orders/{orderIDtoReplace}",
                orderJson);
        }

        public async Task<string> CancelOrderAsync(Int64 accountID, Int64 orderID)
        {
            return await SendServiceCall<string>(
                HttpMethod.Delete,
                $"/accounts/{accountID}/orders/{orderID}");
        }


        public async Task<string> CreateSavedOrderAsync(Int64 accountID, Order order)
        {
            string orderJson = Shared.Utilities.JsonConfig.SerializeObject(order);

            return await SendServiceCall<string>(
                HttpMethod.Post,
                $"/accounts/{accountID}/savedorders",
                orderJson);
        }
        public async Task<string> DeleteSavedOrderAsync(Int64 accountID, Int64 savedOrderID)
        {
            
            return await SendServiceCall<string>(
                HttpMethod.Delete,
                $"/accounts/{accountID}/savedorders/{savedOrderID}");
        }
        public async Task<Order> GetSavedOrderAsync(Int64 accountID, Int64 savedOrderID)
        {
            string uri = $"/accounts/{accountID}/savedorders/{savedOrderID}";
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);
            return Shared.Utilities.JsonConfig.DeserializeObject<Order>(response);
        }
        public async Task<IList<Order>> GetSavedOrdersByPathAsync(Int64 accountID)
        {
            //TODO: the From date should be within 60 days.. check for that.

            string uri = $"/accounts/{accountID}/savedorders";
            
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);

            return Shared.Utilities.JsonConfig.DeserializeObject<IList<Order>>(response);
        }
        public async Task<string> ReplaceSavedOrderAsync(Int64 accountID, Int64 replacedSavedOrderID, Order order)
        {
            string orderJson = Shared.Utilities.JsonConfig.SerializeObject(order);

            return await SendServiceCall<string>(
                HttpMethod.Put,
                $"/accounts/{accountID}/savedorders/{replacedSavedOrderID}",
                orderJson);
        }
        public async Task<IList<SecuritiesAccount>> GetAccountsAsync(bool includePositions = false, bool includeOrders = false)
        {
            string uri = $"/accounts";
            if(includePositions == true && includeOrders == true)
            {
                uri += "?fields=positions,orders";
            }
            else if(includePositions == true && includeOrders == false)
            {
                uri += "?fields=positions";
            }
            else if(includePositions == false && includeOrders == true)
            {
                uri += "?fields=orders";
            }
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);

            var map = Shared.Utilities.JsonConfig.DeserializeObject<IList<IDictionary<string, SecuritiesAccount>>>(response);
            IList<SecuritiesAccount> result = new List<SecuritiesAccount>();
            foreach(var dic in map)
            {
            foreach(var entry in dic.Values)
            {
                result.Add(entry);
            }
            }

            return result;
        }
        public async Task<SecuritiesAccount> GetAccountAsync(string accountID, bool includePositions = false, bool includeOrders = false)
        {
            string uri = $"/accounts/{accountID}";
            if(includePositions == true && includeOrders == true)
            {
                uri += "?fields=positions,orders";
            }
            else if(includePositions == true && includeOrders == false)
            {
                uri += "?fields=positions";
            }
            else if(includePositions == false && includeOrders == true)
            {
                uri += "?fields=orders";
            }
            string response = await SendServiceCall<string>(HttpMethod.Get, uri);

            return Shared.Utilities.JsonConfig.DeserializeObject<SecuritiesAccount>(response);
        }
    }
}