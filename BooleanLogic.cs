using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            int age, speedingTickets;
            bool hadDUI;

            Console.WriteLine("What is your age?");
            age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? true or false");
            hadDUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            speedingTickets = Console.WriteLine();

            bool qualified;

            if (age < 15 && hadDUI == false && speedingTickets <= 3)
                qualified = true;
            else
                qualified = false;

            Console.WriteLine("Qualified?\n" + qualified);
            Console.ReadLine();

        }
    }
}