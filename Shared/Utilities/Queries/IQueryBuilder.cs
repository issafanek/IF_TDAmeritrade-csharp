using System.Collections.Generic;

namespace TDAmeritrade.Shared.Utilities.Queries
{
    public interface IQueryBuilder
    {
        string BuildQuery(params KeyValuePair<string, string>[] queryParameters);
    }
}