using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CriticalSection
{
    public class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Поток # {0}: шаг {1}", hash, i);
                    Thread.Sleep(300);
                }
                Console.WriteLine(new string('-', 20));
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            var myClass = new MyClass();

            for (int i = 0; i < 3; i++)
            {
                new Thread(myClass.Method).Start();
                //myClass.Method();
            }

            Thread.Sleep(2000);
            
        }
    }
}
