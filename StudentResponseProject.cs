using System;


namespace StudentResponseProject.cs
{
    class Program
    {
        static void Main()
        {
            //Upon starting the application, the following two phrases will be printed.
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //The following will dictate the variables that will be used further on
            string stdName, currentCourse, positiveExp, otherFeedback;
            int pageNum, studyTime;
            bool needHelp;

            //The following is to ask questions and store that data
            Console.WriteLine("A. What is your name?");
            stdName = Console.ReadLine();

            Console.WriteLine("B. What course are you on?");
            currentCourse = Console.ReadLine();

            Console.WriteLine("C. What page number?");
            pageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("D. Do you need help with anything? Please answer \"true\" or \"false\"");
            needHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("D. Were there any positive experiences you'd like to share? Please give specifics.");
            positiveExp = Console.ReadLine();

            Console.WriteLine("F. Is there any other feedback you' like to provide? Please be specific.");
            otherFeedback = Console.ReadLine();

            Console.WriteLine("G. How many hours did you study today?");
            studyTime = Convert.ToInt32(Console.ReadLine());

            //Once all data is provided the console will print the following. 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
