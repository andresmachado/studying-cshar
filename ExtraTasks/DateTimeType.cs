using System.Globalization;

namespace OtherTasksNamespace

{
    public static class DateTimeType
    {

        public static void Culture()
        {
            Console.WriteLine("\n----------------- Culture -----------------");
            var pt = new CultureInfo("pt-BR");
            var current = CultureInfo.CurrentCulture;
            Console.WriteLine(current);
            Console.WriteLine(pt);
            Console.WriteLine(pt.DateTimeFormat.ShortDatePattern);
            Console.WriteLine(DateTime.UtcNow.ToString("r", pt));

            Console.WriteLine("\n----------------- Time zones -----------------");
            // Converting time zones the right way
            // var allTimeZones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timeZone in allTimeZones)
            // {
            //     Console.WriteLine(timeZone.Id);
            // }
            var utc = DateTime.UtcNow;
            var brazil = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utc, brazil));

            // TimeSpan
            Console.WriteLine("\n----------------- TimeSpan -----------------");
            var timeSpanHoursMinutesSeconds = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timeSpanHoursMinutesSeconds);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
        }

        public static void ExampleDateTime()
        {
            //var dateTime = DateTime.Now;
            Console.WriteLine("\n----------------- DateTime -----------------");
            var dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine("yyyy-MM-dd: " + dateTime.ToString("yyyy-MM-dd"));
            Console.WriteLine("d: " + dateTime.ToString("d"));
            Console.WriteLine("yyyy-MM-dd HH:mm: " + dateTime.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine("t: " + dateTime.ToString("t"));
            Console.WriteLine("f: " + dateTime.ToString("f"));
            Console.WriteLine("g: " + dateTime.ToString("g"));
            Console.WriteLine("r: " + dateTime.ToString("r"));
            Console.WriteLine("s: " + dateTime.ToString("s"));
            Console.WriteLine("U: " + dateTime.ToString("U"));
            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Hour);
            Console.WriteLine(dateTime.Minute);
            Console.WriteLine(dateTime.Second);
            Console.WriteLine(dateTime.Millisecond);
            Console.WriteLine((int)dateTime.DayOfWeek);
            Console.WriteLine(dateTime.DayOfYear);
            Console.WriteLine(dateTime.TimeOfDay);
            Console.WriteLine(dateTime.Date);
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToShortDateString());

            var formatted = String.Format("{0:yyyy-MM-dd HH:mm}", dateTime); // This is the same as dateTime.ToString("yyyy-MM-dd HH:mm")
            Console.WriteLine(formatted);

            // Date calculations. The result is a new DateTime object. 
            // It works with AddYears, AddMonths, AddDays, AddHours, AddMinutes, AddSeconds, AddMilliseconds
            Console.WriteLine("\n----------------- Date calculations -----------------");
            Console.WriteLine(dateTime.AddHours(2));
            Console.WriteLine(dateTime.AddDays(2));
            Console.WriteLine(dateTime.AddMonths(2));

            // Date comparison. Date is a value type, so can use the comparison operators.
            // The result is a boolean value (true or false). It works with <, >, ==, !=
            Console.WriteLine("\n----------------- Date comparison -----------------");
            var date1 = new DateTime(2024, 1, 1);
            var date2 = new DateTime(2024, 1, 2);
            Console.WriteLine("Is date < date2? " + (date1 < date2));
            Console.WriteLine("Is date == date2? " + (date1 == date2));
            Console.WriteLine("Is date != date2? " + (date1 != date2));
            Console.WriteLine("Is date > date2? " + (date1 > date2));
        }
    }
}
