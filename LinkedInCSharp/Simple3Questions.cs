using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    class SimpleQuestion
    {
        private static void SimpleQuestions()
        {

            //while (answare != 'y' || answare != 'n')
            //{
            Console.WriteLine("Simple Questions");
            Console.Write("Please enter your name: ");
            string name = TryAgain();

            Console.Write("How old are you: ");
            var age = TryAgain();

            Console.Write("What month were you born in: ");
            string month = TryAgain();


            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your birth month is {0}", month);
            Console.WriteLine("Is this correct ?!");
            char answare = char.Parse(Console.ReadLine());
            if (answare == 'y')
            {
                Console.WriteLine("Thank you.");
            }
            else if (answare != 'y')
            {
                Console.WriteLine("Please type again.");
            }
        }
        public static string TryAgain()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                while (question == "")
                {
                    Console.WriteLine("You did not type anything. Please try again.");
                    return Console.ReadLine();
                }
            }
            return question;
        }
        public static void RunExample()
        {
            SimpleQuestions();
        }
    }
}   


