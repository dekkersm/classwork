using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thedate
{
    class Program
    {
        static string Onot(int a, int b, int c)
        {
            if ((b == 1) || (b == 2) || (b == 3) || (b == 12))
                return "winter";
            else if ((b == 4) || (b == 5))
                return "spring";
            else if ((b == 6) || (b == 7) || (b == 8) || (b == 9))
                return "summer";
            else
                return "fall";
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            int day=
        }
    }
}
