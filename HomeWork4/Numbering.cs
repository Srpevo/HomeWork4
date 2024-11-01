using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Numbers
{
    internal class Numbering
    {
        public static void AddNumberingWithColor<T>(T value, ConsoleColor Color)
        {
            ConsoleColor Temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine("#{0}", value);
            Console.ForegroundColor = Temp;
        }
    }
}
