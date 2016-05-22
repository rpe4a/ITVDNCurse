using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCollection.Core;

namespace UserCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Core.UserCollection myCollection = new Core.UserCollection();

            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0}, Field1: {1}, Field2: {2}", element.Name, element.Field1, element.Field2);
            }
        }
    }
}
