using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            int weight, width, height, length, totalDimensions, totalPrice;
            

            Console.WriteLine("Welcome to Package Express. Please follow the instruction below. ");
            Console.WriteLine("Please enter the package weight.");
            weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day. ");
            }

            Console.WriteLine("Please enter the package width.");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height.");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length.");
            length = Convert.ToInt32(Console.ReadLine());

            totalDimensions = width + height + length;

            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            totalPrice = ((width * height * length) * weight) / 100;

            Console.WriteLine("Your estimated toal for shipping this package is: $" + totalPrice);
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}