using System;

namespace Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("\n");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            byte pageInt = Convert.ToByte(page); // we know that there is less that 255 pages

            Console.WriteLine("\n");

            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(help);
            string helpNeeded = helpBool ? "need" : "don't need";

            Console.WriteLine("\n");

            Console.WriteLine("Were there any positive experiences you’d like to share?  Please provide specifics.");
            string comment = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Is there any other feedback you’d like to provide?  Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            double hoursFloat = Convert.ToDouble(hours);

            //Writing the summary as well
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine("Your answers:");
            Console.WriteLine("\n");

            Console.WriteLine("The Course You are doing now is: " + course + ". You are on page " + pageInt + " and You " + helpNeeded + " help with the course.");
            Console.WriteLine("\n");

            Console.WriteLine("Also you provided a comment : " + comment);
            Console.WriteLine("\n");

            Console.WriteLine("And a feedback : " + feedback);
            Console.WriteLine("\n");

            Console.WriteLine("TOTAL HOURS STUDIED TODAY: " + hoursFloat);
            Console.WriteLine("\n");

            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!");
            Console.ReadLine();



        }

    }
}
