using System;

namespace TechAcademySurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
                string courseNum = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
                int pageNum = Console.ReadLine();
                /*string pageNum = Console.ReadLine();*/
                //i also included a string value just in case the person wants to answer the question in a complete sentence.
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'?");
                bool help = Console.ReadLine();
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
                string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
                string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
                int studyHours = Console.ReadLine();
                /*string studyHours = Console.ReadLine();*/
            Console.WriteLine("Thank you for your Answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
