using System;

namespace GPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Subject name: ");
                string subject = Console.ReadLine();
                Console.WriteLine("Subject type (Core/Major/Minor/Elective");
                string subjectType = Console.ReadLine();
                //SubjectType subject = (SubjectType)subjectType;
                Console.WriteLine("Would you like to add another subject? y/n: ");
                input = Console.ReadLine();
            } while (input != "n");
        }
    }
}
