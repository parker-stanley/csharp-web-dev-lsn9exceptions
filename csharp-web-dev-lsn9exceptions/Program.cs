using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            if (x != 0)
            {
                return x / y;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName == null || fileName == "")
            {
                throw new ArgumentException();
            }
            else if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(0, 1));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Possible points cannot be zero.");
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.php");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string,string> student in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(student.Value));
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Students must submit a file for grading.");
                }
            }

        }
    }
}
