using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int serviceLevel;
            int highService = 0;
            int lowService = 0;
            double price = 0;
            double sum = 0;
            do
            {
                do
                {
                    Console.WriteLine("insert one of the folowing numbers: 1 / 2 / 3 / 9");
                    serviceLevel = int.Parse(Console.ReadLine());
                }
                while ((serviceLevel < 1 || serviceLevel > 3) && serviceLevel != 9 );//running the loop as long as the service level is between 1 and 3, and not 9 
                if (serviceLevel != 9)//if the service level is 9 do not ask for price and exit loop
                {
                    Console.WriteLine("please type the amount you spent");
                    price = double.Parse(Console.ReadLine());
                }
                if (serviceLevel == 1)//if the service level is 1 add price to sum and increment service level count
                {
                    sum = sum + price;
                    highService++;
                }
                else if (serviceLevel == 3)
                    lowService++;
            }
            while (serviceLevel != 9);//if the service level is 9 exit loop
            Console.WriteLine(lowService + " customers are not satisfied");
            Console.WriteLine(highService + " customers are satisfied. they spend " + sum + " while shoping");
        }
    }
}
