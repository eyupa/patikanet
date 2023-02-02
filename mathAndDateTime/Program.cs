namespace mathAndDateTime;
class Program
{
    static void Main(string[] args)
    {


        // DateTime
        DateTime myValue = DateTime.Now;
        Console.WriteLine(myValue.ToString()); // 1/1/0001 12:00:00 AM
        Console.WriteLine(myValue.ToShortDateString()); // 1/1/0001
        Console.WriteLine(myValue.ToShortTimeString()); // 12:00 AM
        Console.WriteLine(myValue.ToLongDateString()); // Sunday, January 01, 0001
        Console.WriteLine(myValue.ToLongTimeString()); // 12:00:00 AM
        Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // Wednesday, January 04, 0001
        Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); // 3:00:00 AM
        Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); // Thursday, December 29, 0000
        Console.WriteLine(myValue.Month); // 1
        Console.WriteLine(myValue.Date); // 1
        Console.WriteLine(myValue.Day); // 1
        Console.WriteLine(myValue.Year); // 1
        Console.WriteLine(myValue.Hour); // 1
        Console.WriteLine(myValue.Minute); // 1
        Console.WriteLine(myValue.DayOfWeek); // 1
        Console.WriteLine(myValue.DayOfYear); // 1
        Console.WriteLine(myValue.GetDateTimeFormats()); // 1

        //datetime format
        System.Console.WriteLine(myValue.ToString("dd")); // 01
        System.Console.WriteLine(myValue.ToString("ddd")); // 01
        System.Console.WriteLine(myValue.ToString("dddd")); // 01
        System.Console.WriteLine(myValue.ToString("MM")); // 01
        System.Console.WriteLine(myValue.ToString("MMM")); // 01
        System.Console.WriteLine(myValue.ToString("MMMM")); // 01
        System.Console.WriteLine(myValue.ToString("yy")); // 01
        System.Console.WriteLine(myValue.ToString("yyyy")); // 01

          // Math
        Console.WriteLine(Math.Abs(-40)); // 40
        Console.WriteLine(Math.Pow(2, 3)); // 8
        Console.WriteLine(Math.Sqrt(64)); // 8
        Console.WriteLine(Math.Max(2, 3)); // 3
        Console.WriteLine(Math.Min(2, 3)); // 2
        Console.WriteLine(Math.Round(2.4)); // 2
        Console.WriteLine(Math.Round(2.6)); // 3
        System.Console.WriteLine(Math.Ceiling(2.3)); // 3
        System.Console.WriteLine(Math.Floor(2.7)); // 3
        System.Console.WriteLine(Math.Sin(10)); // 3
        System.Console.WriteLine(Math.Cos(10)); // 3
        System.Console.WriteLine(Math.Tan(10)); // 3
        System.Console.WriteLine(Math.Log(10)); //
        System.Console.WriteLine(Math.Log10(10)); //
        System.Console.WriteLine(Math.Exp(3)); //e to the power of 3
    }
}
