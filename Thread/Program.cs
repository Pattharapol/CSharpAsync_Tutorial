using System;
using System.Threading;

namespace Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintEven);

            Console.Read();
        }

        private static void PrintEven()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
