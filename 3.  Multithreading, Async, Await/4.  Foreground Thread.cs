using System;
using System.Threading;

namespace _3.Multithreading__Async__Await
{
    internal class Program4
    {
        public static void Main4()
        {
            Thread obj1 = new Thread(function1);

            obj1.Start();

            Console.WriteLine("Main Function is Exited ");
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