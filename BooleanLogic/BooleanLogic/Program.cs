using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, speedingTickets;
            bool hadDUI;

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? true or false");
            hadDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            speedingTickets = Convert.ToInt32(Console.ReadLine());

            bool qualified;

            if (age > 15 && hadDUI == false && speedingTickets <= 3)
            {
                qualified = true;
            }

            else
            {
                qualified = false;
            }


            Console.WriteLine("Qualified?\n" + qualified);
            Console.ReadLine();
        }
    }
}
