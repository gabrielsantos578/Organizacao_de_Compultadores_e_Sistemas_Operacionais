// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        public static void Main()
        {
            int i, n = 3;
            for (i = 1; i <= n; i++)
            {
                Loop loop = new Loop(i);
                Thread thread = new Thread(loop.run);
                thread.Start();
                Console.Write("Thread " + i + " criada.\n");
            }
        }

        class Loop
        {
            int thread;
            public Loop(int i)
            {
                thread = i;
            }
            public void run()
            {
                Random random = new Random();
                while (true)
                {
                    Console.Write("Thread " + thread + " executada.\n");
                    try
                    {
                        Thread.Sleep(random.Next(1, 5000));
                    }
                    catch (ThreadInterruptedException) { }
                }
            }
        }
    }

}
