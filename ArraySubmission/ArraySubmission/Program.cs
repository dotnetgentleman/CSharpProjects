using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ArraySubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mario", "Matt", "Larissa" };

            string nameInput;
            int nameSelect;

            Console.WriteLine("Which name would you like to see? \n0 1 or 2");
            nameInput = Console.ReadLine();
            bool isNum = int.TryParse(nameInput, out nameSelect);
            bool isValid = isNum && nameSelect >= 0 && nameSelect <= 2;

            while (!isValid)
            {
                Console.WriteLine("That is not a valid input. Try again. \n0, 1 or 2");
                nameInput = Console.ReadLine();
                isNum = int.TryParse(nameInput, out nameSelect);
                isValid = isNum && nameSelect >= 0 && nameSelect <= 2;
            }

            Console.WriteLine(names[nameSelect]);




            int[] numArray = { 20, 3, 50, 40, 23 };

            int numSelect;
            string numInput;
            
            Console.WriteLine("Which number in the array are you needing? \n0, 1, 2, 3, or 4");
            numInput = Console.ReadLine();

            bool numTrue = int.TryParse(numInput, out numSelect);
            bool numValid = numTrue && numSelect >= 0 && numSelect <= 4;
            
            while (!numValid)
            {
                Console.WriteLine("That is an invalid option. Please try again.\n0, 1, 2, 3, or 4");
                numInput = Console.ReadLine();

                numTrue = int.TryParse(numInput, out numSelect);
                numValid = numTrue && numSelect >= 0 && numSelect <= 4;
            }

            Console.WriteLine("You chose " + numArray[numSelect]);



            List<string> cars = new List<string>();
            cars.Add("Mercedes");
            cars.Add("Toyota");
            cars.Add("Suburu");
            cars.Add("Lamborgini");

            string carInput;
            int carSelect;

            Console.WriteLine("Which car did you need? \n 0, 1, 2, or 3");
            carInput = Console.ReadLine();

            bool inputNum = int.TryParse(carInput, out carSelect);
            bool inputValid = inputNum && carSelect >= 0 && carSelect <= 3;

            while (!inputValid)
            {
                Console.WriteLine("That is an incorrect input. \n 0, 1, 2, or 3");
                carInput = Console.ReadLine();
                inputNum = int.TryParse(carInput, out carSelect);
                inputValid = inputNum && carSelect >= 0 && carSelect <= 3;
            }

            Console.WriteLine("You chose a " + cars[carSelect]);
            Console.ReadLine();
        }
    }
}
