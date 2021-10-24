using TDAmeritrade.Services.Instruments;
using TDAmeritrade.Services.PriceHistory;
using TDAmeritrade.Services.Orders;
using TDAmeritrade.Services.MarketHours;
using TDAmeritrade.Services.OptionChains;
using TDAmeritrade.Services.TransactionHistory;

namespace TDAmeritrade
{
    public interface ITDAmeritradeClient
    {
        IInstrumentsService InstrumentsService { get; }
        IPriceHistoryService PriceHistoryService { get; }
        IOrdersAndAccountsService OrdersAndAccountsService { get; }
        IMarketHoursService MarketHoursService { get; }
        IOptionChainsService OptionChainsService { get; }
        ITransactionHistoryService TransactionHistoryService { get; }
    }
}