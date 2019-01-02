using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();

            int number = myRand.Next(1, 4);

            if(number == 1)
            {
                Console.WriteLine("YO DAWG");
            }
            else if(number == 2)
            {
                Console.WriteLine("HELLO WORLD");
            }
            else
            {
                Console.WriteLine("HOWDY YALL");
            }

            Console.ReadKey();

        }
    }
}
