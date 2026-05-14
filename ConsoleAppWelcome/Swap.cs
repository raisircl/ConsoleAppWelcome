using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWelcome
{
    internal class Swap
    {
        static void Main()
        {
            int a, b, t;
            Console.WriteLine("enter number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            b = Convert.ToInt32(Console.ReadLine());
            t = a;
            a = b;
            b = t;
            Console.WriteLine($"After swap A={a} and B={b}");

        }
    }
}
