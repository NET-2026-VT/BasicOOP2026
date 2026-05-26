using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP2026
{
    internal static class StringExtensions
    {
        public static string AddString(this string firstWord, string secondWord)
        {
            return $"{firstWord} {secondWord}"; 
        }
    }
}
