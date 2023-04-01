using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Multithreading__Async__Await
{
    internal class Program2
    {
        public static void Main2()
        {
            var k = Method1();
            Method2();
            Console.ReadKey();
        }

        public async static Task<int> Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(" Method 1 " + i.ToString());

                    Task.Delay(100).Wait();
                }
            });

            return 10;
        }

        public static void Method2()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(" Method 2 " + i.ToString());

                Task.Delay(100).Wait();
            }
        }
    }
}