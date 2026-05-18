//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppWelcome
//{
//    internal class MyFunctions
//    {
//        static void Main() // calling function
//        {
//            Console.WriteLine("Welcome to Main");
//            Msg(); // calling 
//            Console.WriteLine("Welcome to Main again");
//            table(10);
//            int x = Factorial(5);
//            Console.Write($"\b={x}");

//            double r, area;
//            r = 5.3;
//            area=GetPi() * r * r;
//            Console.WriteLine($"\nArea of circle with radius {r} is {area}");
//        }
//        static void Msg() // called function    
//        {
//            Console.WriteLine("I am a function does not accept and return");
//        }
//        static void table(int num) // does not return anything but accept parameter type int
//        {
//            int i;
//            for (i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{num} x {i} = {num * i}");
//            }
//        }
//        static int Factorial(int num) // accept parameter and return type int
//        {
//            int f = 1, i;
//            for (i = num; i >= 1; i--)
//            {
//                Console.Write($"{i}x");
//                f = f * i;
//            }
//            return f;
//        }
//        static double GetPi() // does not accept parameter but return type double
//        {
//            return 3.14;
//        }
//    }
//}

///*
// Function - 
//        1. Block of Code under a Name
//        2. Function sign agreement that is just call me and use me 
//        3. Reusable code 
//        4. Function has 4 types 
//            4.1. No parameter and no return type (does not accept and does not return anything)
//                 We define a function with void return type and enpty parenthesis 
                
//            2. Parameter but no return type
//            3. No parameter but return type
//            4. Parameter and return type
 
// */
