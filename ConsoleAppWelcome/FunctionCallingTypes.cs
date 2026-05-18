using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppWelcome
{
    // call by value
    // call by reference
    // call by out
    internal class FunctionCallingTypes
    {
        static void Main()
        {
            int a = 10;
            Console.WriteLine($"Before call value of A={a}");
            //fun(a); // a is actual parameter and x is formal parameter
            fun2(ref a); // a is actual parameter and x is formal parameter 
            // in call by ref if any change in formal parameter also affect actual parameter because both are same memory location but in call by value if any change in formal parameter does not affect actual parameter
            // in call by value if any change in formal parameter does not affect actual parameter
            Console.WriteLine($"After call value of A={a}");

            int h = 80, e = 90, m = 95, sci = 85, sst = 75, t=0;
            double p;
            result(h, e, m, sci, sst, out t, out p);
            Console.WriteLine($"Total marks is {t} and percentage is {p}");
        }
        static void fun(int x) // value of a is copied to x and x is formal parameter and a is actual parameter
        {
            x = x + 10; // value of x is changed but value of a is not changed
            Console.WriteLine($"Value of x inside fun function is {x}");
        }
        static void fun2(ref int x)
        {
            x = x + 10; // value of x is changed but value of a will changed
            Console.WriteLine($"Value of x inside fun function is {x}");

        }
        static void result(int h, int e, int m, int sci, int sst, out int total, out double per)
        {
            
            total = h + e + m + sci + sst;
            per = total / 5.0;
        }
    }
}
