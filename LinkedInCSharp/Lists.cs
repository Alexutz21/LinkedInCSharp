using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCSharp
{
    enum School
    {
        Hogwards, Harward, MIT
    }
    class Lists
    {
        static List<Student> students = new List<Student>();

        private static void StudentAdd()
        {
            //Console.Write("How many students are in your class: ");
            //var studentsCounts = int.Parse(Console.ReadLine());
            //Import();
            

            /*  classic way to initialization fields
             * var studentNames = new List<string>();
             * var studentGrades = new List<int>();          
             * var studentBirthday = new List<string>();            
             * var studentAdress = new List<string>();          
             * var studentPhoneNumber = new List<int>();          
             */

            var adding = true;

            while (adding)
            { 
                    var newStudent = new Student();

                    Student.Count++;
                    Console.WriteLine("Student number: {0}", Student.Count);

                    //Console.Write("Student Name: ");    //without our new method Ask
                    //newStudent.Name=(Console.ReadLine()); 
                  newStudent.Name = Util.Console.Ask("Student Name: ");
                 
                    //Console.Write("Student Grade: ");    //without our new method Ask
                    //newStudent.Grade=(Console.ReadLine());
                  newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    //var result = int.TryParse(Util.Console.Ask("Student Grade: "), out newStudent.Grade);
                    //if (!result)
                    //{
                    //    Console.WriteLine("Error! Please enter a valid number.");
                    //    //while (result != null)
                    //    //{
                    //    //    int.TryParse(Util.Console.Ask("Student Grade: "), out newStudent.Grade);
                    //    //    Console.WriteLine("Error. Pleasse retry!");
                    //    //}
                    //}
                  students.Add(newStudent);

                  newStudent.School = (School) Util.Console.AskInt("School name (type coresponding number) \n0: Hogwards High \n1: Harward High \n2: MIT\n");

                    //Console.Write("Student Birthday: ");    //without our new method Ask
                    //newStudent.Birthday=(Console.ReadLine());
                  newStudent.Birthday = (Util.Console.Ask("Student Birthday: "));

                    //Console.Write("Student Adress: ");    //without our new method Ask
                    //newStudent.Address=(Console.ReadLine()); 
                  newStudent.Address = (Util.Console.Ask("Student Address: "));

                    //Console.Write("Student Phone Number: ");
                    //newStudent.setPhone(int.Parse(Console.ReadLine())); //encapsulation
                  newStudent.setPhone(int.Parse(Util.Console.Ask("Student Phone Number: ")));

                    Console.WriteLine("Add another? Y/N");
                    if (Console.ReadLine() != "y")
                        adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, School name: {2}, Birthday: {3}, Address: {4}, Phone: {5}", student.Name, student.Grade, student.School, student.Birthday, student.Address, student.Phone);
                Export();
            }
            
            //here we count the number of total students
            int StudentCountTotal = Student.Count;
            Console.WriteLine("Total students added: {0}", StudentCountTotal);
        }

        static void Import()    //method for importing students
        {
            var importedStudent = new Student("Johnny", 9, "birthday", "address", 0752817792);
            Console.WriteLine(importedStudent.Name);

        }
        static void Export()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwards:
                        Console.WriteLine("Exporting to Hogwards");
                        break;
                    case School.Harward:
                        Console.WriteLine("Exporting to Harward");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                    default:
                        Console.WriteLine("It is not a school");
                        break;
                }
            }
        }
        class Member
        {
            public string Name;
            public string Address;
            public int Phone;
        }
        class Student : Member
        {
            public static int Count = 0;
            //we declare a variable of total student and is equal to count
            public int StudentCountTotal = Count;

            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            public int Phone;
            public School School;   //we use the enum created on top 

            //empty constructor
            public Student()    
            {

            }
            //constructor with atriubutes
            public Student(string name, int grade, string birthday, string address, int phone)
            {
                Name = name;
                Grade = grade;
                Birthday = birthday;
                Address = address;
                Phone = phone;
            }
            // we create a method for the field Phone witch is private now
            
            public void setPhone(int number)
            {
                Phone = number;
            }

            //internal object setPhone()
            //{
            //    throw new NotImplementedException();
            //}
        }
        class Teacher : Member
        {
            public string Subject;

            public void setPhone(int number)
            {
                Phone = number;
            }
        }
        public static void RunExample()
        {
            StudentAdd();
        }
    }
}
