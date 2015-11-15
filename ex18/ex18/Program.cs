using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 1;
            long num2 = 1;
            Console.WriteLine(num1);
            while (num2 < 50)//running the loop as long as the number is less than 50
            {
                Console.WriteLine(num2);
                num2 = num1 + num2;
                num1 = num2 - num1;
            }
        }
    }
}
