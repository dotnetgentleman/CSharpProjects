using System;
using System.Collections.Generic;
using System.Linq;

namespace sixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mario ", "Larissa ", "Daniel ", "Peter ", "Angel " };

            string lName;
            Console.WriteLine("Please enter a last name.");
            lName = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = name[i] + lName;
            }

            for (int j = 0; j < name.Length; j++)
            {
                Console.WriteLine(name[j]);
                
            }
            Console.ReadLine();

            int f = 2;
            do
            {
                Console.WriteLine("Hi");
            } while (f == 0);

            while (f < 3)
            {
                Console.WriteLine("Yes");
                f++;
            }

            while (f <= 3)
            {
                Console.WriteLine("No");
                f++;
            }

            List<string> items = new List<string> ();
            //If bool items.contains(userInput) is true write the index.
            items.Add("Food");
            items.Add("TV");
            items.Add("Car");
            items.Add("Toy");
            //This is to test whether the program stops after finding Car once.
            items.Add("Car");

            Console.WriteLine("Enter your search. ");
            string userInput = Console.ReadLine();

            bool search = items.Contains(userInput);

            if (search == false)
            {
                Console.WriteLine("Your search did not yield any results.");

            }

            else
            {
                bool isTrue = false;
                while (isTrue == false)
                {
                    for (int i = 0; i <= items.Count; i++)
                    {
                        if (search == true && i == items.IndexOf(userInput))
                        {
                            Console.WriteLine("The index is " + items.IndexOf(userInput));
                            Console.ReadLine();
                            isTrue = true;
                        }

                    }
                }
                
            }

            List<string> Flavors = new List<string>();
            Flavors.Add("Vanilla");
            Flavors.Add("Coco");
            Flavors.Add("Strawberry");
            Flavors.Add("Vanilla");

            Console.WriteLine("Enter the Flavor you want.");
            string userInput2 = Console.ReadLine();

            bool search2 = Flavors.Contains(userInput2);

            if (search2 != true)
            {
                Console.WriteLine("Your search did not yield any results.");
                Console.ReadLine();
            }
            
            else
            {
                for (int j = 0; j < Flavors.Count; j++)
                {
                    if (Flavors[j].Equals(userInput2))
                        Console.WriteLine(j);

                }
            }


            //Create a list of strings with a duplicate item

            List<string> Movies = new List<string>();
            Movies.Add("Up");
            Movies.Add("It");
            Movies.Add("Up");
            Movies.Add("Thor");

            List<string> duplicate = new List<string>();


            //Create a foreach loop that checks each item to see if it has already been shown

            foreach (string Movie in Movies)
            {
                
                if (duplicate.Contains(Movie) == false)
                {
                    duplicate.Add(Movie);
                    Console.WriteLine("Only one in list.");
                }
                else
                {
                    Console.WriteLine("Is already in list");
                    Console.ReadLine();
                }
                
            }

        }
    }
}
