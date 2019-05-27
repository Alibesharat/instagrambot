using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Spigram.Extensions
{
    public static class EnumExtention
    {
        
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString())
                           .First()
                           .GetCustomAttribute<DisplayAttribute>()
                           .Name;
        }
        public static string GetShortName(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString())
                           .First()
                           .GetCustomAttribute<DisplayAttribute>()
                           .ShortName;
        }

        public static T ToEnum<T>(this string value, T defaultValue)
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }
            try
            {
                return (T)Enum.Parse(typeof(T), value, true);

            }
            catch
            {

                return defaultValue;
            }
        }

    }
}
