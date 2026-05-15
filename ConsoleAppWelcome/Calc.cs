//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleAppWelcome
//{
//    internal class Calc
//    {
//        static void Main()
//        {
//            int a, b, choice=0;
//            Console.WriteLine("enter number 1");
//            a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter number 2");
//            b = Convert.ToInt32(Console.ReadLine());
//            do
//            {
//                Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
//                Console.WriteLine("Enter your choice:");
//                choice = Convert.ToInt32(Console.ReadLine());
//                switch (choice)
//                {
//                    case 1:
//                        Console.WriteLine($"sum of {a} and {b} is {a + b}");
//                        break;
//                    case 2:
//                        Console.WriteLine($"difference of {a} and {b} is {a - b}");
//                        break;
//                    case 3:
//                        Console.WriteLine($"product of {a} and {b} is {a * b}");
//                        break;
//                    case 4:
//                        Console.WriteLine($"quotient of {a} and {b} is {(float)a / b}");
//                        break;
//                    case 5:
//                        choice = 0;
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice");
//                        break;
//                }

//            } while (choice!=0);
            
//        }
//    }
//}
