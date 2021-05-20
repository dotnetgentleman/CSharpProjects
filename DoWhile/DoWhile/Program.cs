using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a while statement with a boolean comparison 
            bool start;

            Console.WriteLine("Would you like to start the program? true or false");
            start = Convert.ToBoolean(Console.ReadLine());

            while (start == true)
            {
                Console.WriteLine("You have started the program. ");
                Console.ReadLine();

                int i = 0;

                do
                {
                    i++;
                    Console.WriteLine(i);

                } while (i < 20);
                Console.ReadLine();

                start = false;
            }

            Console.Clear();
            Console.WriteLine("Program terminated.");
            Console.ReadLine();


            
        }
    }
}
