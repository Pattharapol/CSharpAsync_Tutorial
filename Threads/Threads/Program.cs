using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print(false);
            //Print(true);

            Thread t1 = new Thread(() => Print(false));
            t1.Start();

            Thread t2 = new Thread(() => Print(true));
            t2.Start();

            Thread.Sleep(100);

            Console.Read();
        }

        private static void Print(bool isEven)
        {
            //bool isEven = (bool)arg;
            Console.WriteLine($"CUrrent Thread ID : {Thread.CurrentThread.ManagedThreadId}");
            if (isEven)
            {
                for (int i = 0; i < 3000; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " from thread 1");
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3000; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i + " from thread 2");
                    }
                }
            }

            
        }
    }
}
