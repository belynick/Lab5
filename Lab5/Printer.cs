using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class Printer
    {
        Random random = new Random();

        public void Print(string value)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
