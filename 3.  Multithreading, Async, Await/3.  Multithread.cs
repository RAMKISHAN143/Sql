using System;
using System.Threading;

namespace _3.Multithreading__Async__Await
{
    internal class Program3
    {
        public static void Main3()
        {
            Thread obj1 = new Thread(function1);
            Thread obj2 = new Thread(function2);

            obj1.Start();
            obj2.Start();

            Console.ReadLine();
        }

        public static void function1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function1 is Executed " + i.ToString());

                Thread.Sleep(2000);                                                  // Delay 2 Seconds
            }
        }

        public static void function2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function2 is Executed " + i.ToString());

                Thread.Sleep(2000);
            }
        }
    }
}