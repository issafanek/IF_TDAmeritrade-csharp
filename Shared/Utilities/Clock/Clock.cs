using System;

namespace TDAmeritrade.Shared.Utilities.Clock
{
    public class Clock : IClock
    {
        public DateTime GetTime()
        {
            return DateTime.UtcNow;
        }
    }
}
