using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJump.Shared
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }
    }
}
