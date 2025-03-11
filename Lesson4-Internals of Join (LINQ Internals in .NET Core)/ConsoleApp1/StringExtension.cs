using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public static class StringExtension
    {
        public static string GiveFirstCharacter(this string item)
        {
            return item.Substring(0, 1);
        }
    }
}