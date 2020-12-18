using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string toprint)
        {
            Console.WriteLine(toprint);
        }
    }
}
