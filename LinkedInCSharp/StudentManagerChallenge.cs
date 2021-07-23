using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    class StudentManagerChallenge
    {
        private static void StudentName()
        {
            Console.Write("How many students are in your class: ");
            var studentsCounts = int.Parse(Console.ReadLine());

            var studentNames = new string[studentsCounts];
            var studentGrades = new int[studentsCounts];

            for (int i = 0; i < studentsCounts; i++)
            {
                Console.Write("Student Name: ");
                studentNames[i] = Console.ReadLine();

                Console.Write("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studentsCounts; i++)
            {
                Console.WriteLine("Name: {0}\nGrade: {1}",studentNames[i], studentGrades[i]);
            }
        }
        public static void StudentRunExample()
        {
            StudentName();
        }
    }
}
