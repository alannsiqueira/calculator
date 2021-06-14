using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Shared.Extensions
{
    public static class Enumeration
    {
        public static string GetDescription(this Enum enumerador)
        {
            var memberInfo = enumerador.GetType().GetMember(enumerador.ToString());

            if (memberInfo.Length <= 0) return enumerador.ToString();

            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false).ToArray();

            return attributes.Length > 0 ? ((DescriptionAttribute)attributes[0]).Description : enumerador.ToString();
        }
    }
}