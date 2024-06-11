namespace WebAPI.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static long ToLongOrDefault(this string str, long defaultValue = 0)
    {
        return long.TryParse(str, out long result) ? result : defaultValue;
    }
    
    public static int ToIntOrDefault(this string str, int defaultValue = 0)
    {
        return int.TryParse(str, out int result) ? result : defaultValue;
    }

    public static bool ToBoolOrDefault(this string str, bool defaultValue = false)
    {
        return bool.TryParse(str, out bool result) ? result : defaultValue;
    }
    
    public static List<string> JoinAsList(this string source, string cut)
    {
        return string.IsNullOrWhiteSpace(source) ? new List<string>() : source.Split(cut).ToList();
    }
}