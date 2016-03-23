using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int grd;
            int avg;
            int sum = 0;
            for(int i = 0; i < 10; i++)//running the loop as long as there are less than 10 grades
            {
                Console.WriteLine("insert a grade");
                grd = int.Parse(Console.ReadLine());
                sum = grd + sum;
            }
            avg = sum / 10;//calculating the average
            Console.WriteLine("the average of the grades is: "+avg);
        }
    }
}
