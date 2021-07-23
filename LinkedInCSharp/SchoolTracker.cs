using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    class SchoolTracker
    {
        public static void Example1()
        {
            int[] studentGrades = new int[10] { 80, 77, 90, 59, 70, 70, 89, 97, 96, 89 };
            Console.WriteLine(studentGrades[3]);

            //studentGrades[0] = 91;     // or we can initialize like this
            //studentGrades[1] = 62;     // our array studentGrades
            //studentGrades[2] = 87;
            //studentGrades[3] = 46;
            //studentGrades[4] = 70;
            Console.ReadLine();
        }
        public static void Example2()
        {
            int[] studentGrades = new int[10] { 80, 77, 90, 59, 70, 70, 89, 97, 96, 89 };
            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
        }
        public static void RunExample()
        {
            //Example1();
            Example2();
        }
    }
}
