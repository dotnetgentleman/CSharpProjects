using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One plus" + " two" + " is equal to three. ");
            Console.ReadLine();

            string name;
            Console.WriteLine("what is your name? ");
            name = Console.ReadLine().ToUpper();

            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("This is the first line.");
            Console.WriteLine(paragraph);
            Console.ReadLine();
            paragraph.Append("\nThis is the second line. ");
            Console.WriteLine(paragraph);
            Console.ReadLine();
            paragraph.Append("\nThis is the final line. ");
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
