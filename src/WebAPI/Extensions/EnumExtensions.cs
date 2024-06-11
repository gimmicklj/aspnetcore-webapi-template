using System.ComponentModel;

namespace WebAPI.Extensions;

public static class EnumExtensions
{
        
    public static string ToDescription(this Enum? enumValue)
    {
        if (enumValue == null) return string.Empty;
        var type = enumValue.GetType();

        var fieldInfo = type.GetField(enumValue.ToString());
        if (fieldInfo != null)
        {
            var attrs = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attrs.Length > 0)
            {
                return attrs[0].Description;
            }
        }
        return enumValue.ToString();
    }

        
    public static Dictionary<string,string> GetEnumList(this Type enumType)
    {
        var result = new Dictionary<string, string>();
        var array = Enum.GetValues(enumType);
        foreach (var item in array)
        {
            var itemName = item.ToString();
            if (!string.IsNullOrEmpty(itemName)) 
            {
                var fieldInfo = item.GetType().GetField(itemName);
                if (fieldInfo != null) 
                {
                    DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);  
                    if (attributes.Length > 0)
                    {
                        result.Add(attributes[0].Description, Convert.ToInt32(item).ToString());
                    }
                }
            }
        }
        return result;
    }
}