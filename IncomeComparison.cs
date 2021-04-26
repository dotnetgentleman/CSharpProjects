using System;


namespace Math.cs
{
    class Program
    {
        static void Main()
        {
            float HourlyOne, HourlyTwo, WorkedOne, WorkedTwo;
            int AnnualOne, AnnualTwo;
            bool MoreMoney;
            
            Console.WriteLine("Anonymous Income Comparison Program \n Person 1: \n Hourly Rate: ");
            HourlyOne = Console.ReadLine();

            Console.WriteLine("Hours worked per week: ");
            WorkedOne = Console.ReadLine();

            Console.WriteLine("Person 2 \n Hourly Rate: ");
            HourlyTwo = Console.ReadLine();

            Console.WriteLine("Hours worked per week: ");
            WorkedTwo = Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1: ");
            HourlyTwo =  Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2? true or false ");
            MoreMoney =  Console.ReadLine();
        }
    }
}