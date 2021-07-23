using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    public class Challenge         // working
    {
        
        public string Name;
        public int Age;
        public string Month;

        public static void Display()
        { 
            while (true)
            {
                var data = new Challenge();
                Console.Write("What is your name: ");
                data.Name = TryAgain();
                Console.Write("How old are you: ");
                data.Age = int.Parse(TryAgain());
                Console.Write("What is your birth month: ");
                data.Month = TryAgain();

                Console.WriteLine($"Your name is {data.Name}");
                    Console.WriteLine("Your age is {0}", data.Age);
                    Console.WriteLine($"Your birth month is {data.Month}");

                    switch (data.Month)
                    {
                        case "december":
                        case "january":
                        case "february":
                            Console.WriteLine("It's winter...Brr...");
                            break;
                        case "march":
                        case "april":
                        case "may":
                            Console.WriteLine("It's spring...Cool...");
                            break;
                        case "june":
                        case "july":
                        case "august":
                            Console.WriteLine("It's summer !!! ... Sun and fun !!!");
                            break;
                        case "september":
                        case "october":
                        case "november":
                            Console.WriteLine("It's almost autummn");
                            break;
                        default:
                            Console.WriteLine("It's not a month.");
                            break;
                    }

                Console.WriteLine();
                Console.WriteLine("Here we go again!!!");
            }
                static string TryAgain()
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
        }   
        public static void RunExample()
        {
            Display();
        }
    }
}
