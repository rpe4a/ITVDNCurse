using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_examples2
{
    class Program
    {

        static void WriteConsole()
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Thread ID {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }   
        }

        static void Main(string[] args)
        {

            Thread thread = new Thread(WriteConsole);
            thread.Start();

            WriteConsole();

            Console.ReadKey();

        }
    }
}
