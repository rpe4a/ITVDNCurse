using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_examples3
{
    class Program
    {
        static void WriteConsole()
        {
            var thread = Thread.CurrentThread;

            thread.Name = "Secondary";

            Console.WriteLine("ID потока {0}: {1}", thread.Name, thread.GetHashCode());

            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {

            var primaryThread = Thread.CurrentThread;

            primaryThread.Name = "Primary";

            Console.WriteLine("ID потока {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());

            var secondaryThread = new Thread(WriteConsole);
            secondaryThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(primaryThread.Name + " " + i);
                Thread.Sleep(1500);
            }

            secondaryThread.IsBackground = true;
        }
    }
}
