using System;
using System.Collections.Generic;

namespace Framework.Comun.Extentensions
{
    public static class StringExtensions
    {
        public static string ToStringSearch(this string @string)
        {
            return string.IsNullOrEmpty(@string) ? @string : string.Format("{0}%", @string);
        }
    }
}
