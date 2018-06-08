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
                string courseNum = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What page number are you on?");
                int pageNum = Convert.ToInt32(Console.ReadLine());
                /*string pageNum = Convert.ToString(Console.ReadLine());*/
                //i also included a string value just in case the person wants to answer the question in a complete sentence.
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'?");
                bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
                string experiences = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
                string feedback = Convert.ToString(Console.ReadLine());
            Console.WriteLine("How many hours did you study today?");
                int studyHours = Convert.ToInt32(Console.ReadLine());
                /*string studyHours = Convert.ToString(Console.ReadLine());*/
            Console.WriteLine("Thank you for your Answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
