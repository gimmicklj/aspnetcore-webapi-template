namespace WebAPI.Extensions;

public static class DateTimeExtensions
{
    
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        var diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).Date;
    }

    public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        var diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(6 - diff).Date;
    }
    
    public static DateTime StartOfMonth(this DateTime dt)
    {
        return new DateTime(dt.Year, dt.Month, 1);
    }

    public static DateTime EndOfMonth(this DateTime dt)
    {
        return dt.AddMonths(1).AddDays(-1);
    }
    

    public static DateTime StartOfYear(this DateTime dt)
    {
        return new DateTime(dt.Year, 1, 1);
    }

    public static DateTime EndOfYear(this DateTime dt)
    {
        return new DateTime(dt.Year, 12, 31);
    }
    
    public static bool IsWeekend(this DateTime dt)
    {
        return dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;
    }
    
    public static DateTime StampToDateTime(string timeStamp)
    {
        DateTime dateTimeStart = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
        var lTime = long.Parse(timeStamp + "0000000");
        var toNow = new TimeSpan(lTime);
        return dateTimeStart.Add(toNow);
    }
    
    public static int DateTimeToStamp(DateTime time)
    {
        var startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
        return (int)(time - startTime).TotalSeconds;
    }
}