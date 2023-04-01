using System;

namespace _3.Multithreading__Async__Await
{
    internal class Program1
    {
        public static void Main1()
        {
            function1();
            function2();

            Console.ReadLine();
        }

        public static void function1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function1 is Executed " + i.ToString());
            }
        }

        public static void function2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function2 is Executed " + i.ToString());
            }
        }
    }
}