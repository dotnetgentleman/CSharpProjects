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

            AnnualOne = HourlyOne * WorkedOne;
            Console.WriteLine("Annual salary of Person 1: " + AnnualOne);

            AnnualTwo = HourlyTwo * WorkedTwo;
            Console.WriteLine("Annual salary of Person 2: " + AnnualTwo);

            if (AnnualOne > AnnualTwo)
                MoreMoney = true;
            else
                MoreMoney = false;


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(MoreMoney);
        }
    }
}