using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Domain.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(System.Enum enumValue)
        {
            var displayAttribute = enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>();

            return displayAttribute?.Name ?? enumValue.ToString();
        }
    }
}