using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MayOrrExercise41
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,2);
            Point p2 = new Point(0,4);
            Console.WriteLine("The distance between {0} and {1} is {2}.",p1.ToString(), p2.ToString(), p1.Distance(p2));
            Console.ReadLine();
        }
    }
}
