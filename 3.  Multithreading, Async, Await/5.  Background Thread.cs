using System;
using System.Threading;

namespace _3.Multithreading__Async__Await
{
    internal class Program5
    {
        public static void Main5()
        {
            Thread obj1 = new Thread(function1);

            obj1.IsBackground = true;                                 // Make this Thread Background Thread
            obj1.Start();

            Console.WriteLine("Main Function is Exited ");
            Console.ReadLine();
        }

        public static void function1()
        {
            Console.WriteLine("Function1 is Started ");
            Console.ReadLine();
            Console.WriteLine("Function1 is Exited ");
            Console.ReadLine();
        }
    }
}