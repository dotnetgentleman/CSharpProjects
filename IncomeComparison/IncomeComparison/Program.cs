using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int HourlyOne, HourlyTwo, WorkedOne, WorkedTwo;
            int AnnualOne, AnnualTwo;
            bool MoreMoney;

            Console.WriteLine("Anonymous Income Comparison Program \n Person 1: \n Hourly Rate: ");
            HourlyOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week: ");
            WorkedOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2 \n Hourly Rate: ");
            HourlyTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week: ");
            WorkedTwo = Convert.ToInt32(Console.ReadLine());

            AnnualOne = 52 * (HourlyOne * WorkedOne);
            Console.WriteLine("Annual salary of Person 1: " + AnnualOne);

            AnnualTwo = 52 * (HourlyTwo * WorkedTwo);
            Console.WriteLine("Annual salary of Person 2: " + AnnualTwo);

            if (AnnualOne > AnnualTwo)
            {
                MoreMoney = true;
            }
                
            else
            {
                MoreMoney = false;
            }
                


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(MoreMoney);
            Console.ReadLine();
        }
    }
}
