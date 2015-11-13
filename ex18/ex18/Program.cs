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
            long temp = 0;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            long sum = 0;
            int count = 2;//count starts at 2 because the first tow numbers were alredy printed
            while(sum<1000)//running the loop as long as the sum is under than 1000
            {
                temp = num1 + num2;
                sum = sum + num2 + temp;//calculating the sum of fibonacci numbers up to this iteration
                num2 = temp;
                Console.WriteLine(num2);
                num1 = num2 - num1;
                count++;
            }
            Console.WriteLine("the number of fibonacci numbers whos sum is less then 1000 is: "+count);
        }
    }
}
