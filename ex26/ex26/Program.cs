using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();//creating the object 'randome'
            int num1 = random.Next(1, 21);//raffling the first edge
            int num2 = random.Next(1, 21);//raffling the second edge
            int num3 = random.Next(1, 21);//raffling the third edge

            if ((num1 + num2 > num3) && (num3 + num1 > num2) && (num2 + num3 > num1))//cheks if a triangle can be formed
            {
                int circ = num1 + num2 + num3;//calculate the circumference
                double p = circ / 2;
                double S = Math.Sqrt(p * (p - num1) * (p - num2) * (p - num3));//calculate the surface
                Console.WriteLine("the raffled edges are: " + num1 + ", " + num2 + ", and " + num3);
                Console.WriteLine("the circumference of the triangle is: " + circ + ", and the surface is: " + S);
            }
            else
            {
                Console.WriteLine("the raffled edges are: " + num1 + ", " + num2 + " and " + num3);
                Console.WriteLine("you can't form a triangle");
            }
        }
    }
}
