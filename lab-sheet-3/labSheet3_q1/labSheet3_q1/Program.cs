using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet3_q1
{
    internal class Program
    {
        public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;

            public Course(string courseName, string instructorName, double grade)
            {
                SetCourseName(courseName);
                SetInstructorName(instructorName);
                SetGrade(grade);
            }

            public string CourseName
            {
                get { return courseName; }
            }

            public double Grade
            {
                get
                {
                    if (grade < 0 || grade > 100)
                    {
                        throw new InvalidOperationException("Grade must be between 0 and 100.");
                    }
                    return grade;
                }
            }

            public void SetInstructorName(string instructorName)
            {
                if (string.IsNullOrWhiteSpace(instructorName))
                {
                    throw new ArgumentException("Instructor name cannot be empty.");
                }
                this.instructorName = instructorName;
            }

            private void SetCourseName(string courseName)
            {
                if (string.IsNullOrWhiteSpace(courseName))
                {
                    throw new ArgumentException("Course name cannot be empty.");
                }
                this.courseName = courseName;
            }

            private void SetGrade(double grade)
            {
                if (grade < 0 || grade > 100)
                {
                    throw new ArgumentException("Grade must be between 0 and 100.");
                }
                this.grade = grade;
            }

            private string CalculateLetterGrade()
            {
                if (grade <= 100 && grade >= 75)
                {
                    return "A";
                }
                else if (grade > 75 && grade <= 65)
                {
                    return "B";
                }
                else if (grade > 65 && grade <= 55)
                {
                    return "C";
                }
                else if (grade > 55 && grade <= 40)
                {
                    return "S";
                }
                else
                {
                    return "F";
                }
            }

            public void PrintCourseInfo()
            {
                Console.WriteLine($"Course Name: {courseName}");
                Console.WriteLine($"Instructor Name: {instructorName}");
                Console.WriteLine($"Letter Grade: {CalculateLetterGrade()}");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Course course1 = new Course("Computer Science", "Charuka Karunarathna", 85);
                course1.PrintCourseInfo();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadLine();
        }
    }
}
