using System;
using TDAmeritrade.Network.Authentication;
using TDAmeritrade.Network.HttpClient;
using TDAmeritrade.Network.HttpRequest;
using TDAmeritrade.Services.Instruments;
using TDAmeritrade.Services.PriceHistory;
using TDAmeritrade.Services.MarketHours;
using TDAmeritrade.Services.OptionChains;
using TDAmeritrade.Services.TransactionHistory;
using TDAmeritrade.Services.Quotes;
using TDAmeritrade.Services.Orders;
using TDAmeritrade.Shared.Utilities.Clock;
using TDAmeritrade.Shared.Utilities.Queries;
using Serilog;

namespace TDAmeritrade
{
    public class TDAmeritradeClient : ITDAmeritradeClient
    {
        public TDAmeritradeClient()
                : this(null, new HttpClient())
        {
        }

        public TDAmeritradeClient(
            IAuthenticator authenticator)
                : this(authenticator, new HttpClient())
        {
        }

        public TDAmeritradeClient(
            IAuthenticator authenticator,
            IHttpClient httpClient)
        {
            var clock = new Clock();
            var httpRequestMessageService = new HttpRequestMessageService(authenticator, clock);
            var queryBuilder = new QueryBuilder();

            InstrumentsService = new InstrumentsService(httpClient, httpRequestMessageService);
            PriceHistoryService = new PriceHistoryService(httpClient, httpRequestMessageService);
            QuotesService = new QuotesService(httpClient, httpRequestMessageService);
            OrdersAndAccountsService = new OrdersService(httpClient, httpRequestMessageService);
            MarketHoursService = new MarketHoursService(httpClient, httpRequestMessageService);
            OptionChainsService = new OptionChainsService(httpClient, httpRequestMessageService);
            TransactionHistoryService = new TransactionHistoryService(httpClient, httpRequestMessageService);
            Log.Information("TDAmeritrade constructed");
        }

        public IInstrumentsService InstrumentsService { get; }
        public IPriceHistoryService PriceHistoryService { get; }
        public IQuotesService QuotesService { get; }
        public IOrdersAndAccountsService OrdersAndAccountsService { get; }
        public IMarketHoursService MarketHoursService { get; }
        public IOptionChainsService OptionChainsService { get; }
        public ITransactionHistoryService TransactionHistoryService { get; }
    }
}