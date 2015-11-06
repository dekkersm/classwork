using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int num1divnum2, num1modnum2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num1divnum2 = num1 / num2;
            num1modnum2 = num1 % num2;
            Console.WriteLine(num1divnum2);
            Console.WriteLine(num1modnum2);

        }
    }
}
