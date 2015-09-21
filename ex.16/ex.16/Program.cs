using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your age - ");
            int age = int.Parse(Console.ReadLine()); /*age, enterd by the user*/

            int days = age * 365; /*clculate the days*/
            int hours = days * 24; /*clculate the hours*/
            int seconds = hours * 3600; /*clculate the seconds*/

            Console.WriteLine("you have lived:");
            Console.WriteLine(days+" days,");
            Console.WriteLine(hours + " hours");
            Console.WriteLine("and "+seconds + " seconds");
        }
    }
}
