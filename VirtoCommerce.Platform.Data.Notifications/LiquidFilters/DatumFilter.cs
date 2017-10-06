using System;

namespace VirtoCommerce.Platform.Data.Notifications.LiquidFilters
{
    public class DatumFilter
    {
        public static string Datum(object input)
        {
            DateTime utcDateTime = (DateTime)input;

            TimeZoneInfo easternEuropeanTime = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

            DateTime dateTime = TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, easternEuropeanTime);

            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
