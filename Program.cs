using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var count = 0;

            //Count from 1 to 100
            Console.WriteLine("Numbers divisble by 3:");
            //Need a loop and print every time
            for (int i = 1; i < 101; i++)
            {

                

                //We need to print the number only when it is divisible by 3 with no remainder
                var divisibleByThree = i % 3;
                if (divisibleByThree == 0)
                {
                    Console.WriteLine(i); //Add to count
                    count++;
                }

            }

            Console.WriteLine("The count is: " + count);

        }
    }
}
