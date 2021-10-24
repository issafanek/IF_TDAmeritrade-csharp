using System.Collections.Generic;
using System.Threading.Tasks;
using TDAmeritrade.Services.Instruments.Models;
using TDAmeritrade.Services.Instruments.Types;

namespace TDAmeritrade.Services.Instruments
{
    public interface IInstrumentsService
    {
         Task<Fundamental> GetFundamentalAsync(string symbol);
         Task<IList<Instrument>> SearchAsync(string searchString, Projection projection);
         Task<Instrument> GetInstrumentByCUSIPAsync(string cusip);
    }
}