using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please type degrees in farenhiet - ");
            float farenhiet = float.Parse(Console.ReadLine());/*degrees in farenhiet enterd by the user*/

            float celcius = (5 * (farenhiet - 32)) / 9;

            Console.WriteLine("{0} degrees in farenhiet is {1} degrees in celcius" ,farenhiet, celcius);

        }
    }
}
