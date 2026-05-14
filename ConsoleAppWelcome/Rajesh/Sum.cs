using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleAppWelcome.Rajesh
{
    internal class Sum
    {
        public void Add()
        {
            int n1, n2, t;
            Console.WriteLine("Enter Number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            t = n1 + n2;
            Console.WriteLine($"The sum is {t}");
        }
    }
}
