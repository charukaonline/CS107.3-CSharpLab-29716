using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter student's marks:");
            int marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Marks should be between 0 and 100.");
            }
            else
            {
                string grade;
                if (marks >= 75)
                {
                    grade = "A";
                }
                else if (marks >= 60)
                {
                    grade = "B";
                }
                else if (marks >= 50)
                {
                    grade = "C";
                }
                else if (marks >= 40)
                {
                    grade = "D";
                }
                else
                {
                    grade = "Fail";
                }

                Console.WriteLine($"Student Name: {name}");
                Console.WriteLine($"Grade: {grade}");
            }
        }
    }
}
