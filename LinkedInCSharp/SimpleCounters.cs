using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    class SimpleCounters
    {
        private static void Example1()  // count from 1 to 10
        {
            var count = 1;
            while (count <= 10)      
            {
                Console.WriteLine(count);
                count++;
            }
        }
        private static void Example2()  // count from 10 to 1
        {
            int count1 = 10;
            while (count1 >= 1)
            {
                Console.WriteLine(count1);
                count1--;
            }
        }
        private static void Example3()  // count from 1 to 10
        {
            for (int i = 1; i < 10; i++)    
            {
                Console.WriteLine(i);
            }
        }
        private static void Example4()
        {   
            for (int k = 1; k <= 5; k++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            } 
        }
        public static void RunExample()
        {
            //Example1();
            //Example2();
            //Example3();
            Example4();
        }
    }
}
