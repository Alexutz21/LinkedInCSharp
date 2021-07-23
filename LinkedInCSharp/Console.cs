using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util  // we also change the namespace 
{
    // we create a utility class that combines the WriteLine and ReadLine
    class Console
    {
        /*
         * our new method Ask replace: Console.Write("Student Adress: ");
         *              and this: newStudent.Address=(Console.ReadLine());
         *                      
         *  With this :  newStudent.Address = (Util.Console.Ask("Student Adress: "));
        */
        static public string Ask (string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
        static public int AskInt(string question)
        {
            System.Console.Write(question);
            return int.Parse(System.Console.ReadLine());
        }
    }
}
