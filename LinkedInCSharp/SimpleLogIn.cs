using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    class SimpleLogIn
    {
        private static void LogIn()
        {

            string password = "";
            while (password != "secret")
            {
                Console.Write("Please enter your password: ");
                password = Console.ReadLine();
                if (password== "secret")
                {
                    Console.WriteLine("You are loged in. Thank you.");
                }
                else
                {
                    Console.WriteLine("Please try again!");
                }
            }
            
        }
        public static void LogInRunExample()
        {
            LogIn();
        }
        
    }
}
