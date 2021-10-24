using System;

namespace TDAmeritrade.Shared.Utilities.Extensions
{
    public static class DateExtensions
    {
        public static double ToTimeStamp(this DateTime date)
        {
            return (date - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }

        public static UInt64 toEPOCH(DateTime datetime)
        {
            TimeSpan t = datetime - new DateTime(1970, 1, 1);
            return (UInt64)t.TotalMilliseconds;
        }
    }
}
