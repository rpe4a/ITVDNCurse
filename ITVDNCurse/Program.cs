using System;
using System.Threading;

namespace Threads_examples
{

    class Program
    {

        static void WriteConsole3()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 30) + "Fourdary");
            }
        }

        static void WriteConsole2()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 20) + "Thirdary");
            }
        }


        static void WriteConsole()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }

        static void Main(string[] args)
        {
            ThreadStart writeStart = WriteConsole;
            Thread thread = new Thread(writeStart);

            ThreadStart writeStart2 = WriteConsole2;
            Thread thread2 = new Thread(writeStart2);

            ThreadStart writeStart3 = WriteConsole3;
            Thread thread3 = new Thread(writeStart3);

            thread.Start();
            thread2.Start();
            thread3.Start();


            while (true)
            {
                Console.WriteLine("Primary");
            }

            Console.ReadKey();
        }
    }
}
