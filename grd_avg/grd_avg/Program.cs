using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grd_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int grd=0;
            int avg;
            int sum=0;
            int count = 0;
            while(grd != 999)//running the loop as long as the grade is diffrent from 999
            {
                sum = grd + sum;
                count++;
                Console.WriteLine("insert a grade");
                grd = int.Parse(Console.ReadLine());
            }
            avg = sum / count; ;//calculating the average
            Console.WriteLine("the average of the grades is : " + avg);
        }
    }
}
