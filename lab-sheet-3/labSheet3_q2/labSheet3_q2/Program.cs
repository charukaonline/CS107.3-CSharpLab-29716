using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labSheet3_q2
{
    internal class Program
    {
        public class Employee
        {
            private int employeeID;
            private string fullName;
            private double salary;

            public Employee()
            {
            }

            public Employee(int employeeID, string fullName, double salary)
            {
                EmployeeID = employeeID;
                FullName = fullName;
                Salary = salary;
            }

            public int EmployeeID
            {
                get { return employeeID; }
                private set { employeeID = value; }
            }

            public string FullName
            {
                get { return fullName; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Full name cannot be empty.");
                    }
                    fullName = value;
                }
            }

            public double Salary
            {
                get { return salary; }
                private set { salary = value; }
            }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"Employee ID: {EmployeeID}");
                Console.WriteLine($"Full Name: {FullName}");
                Console.WriteLine($"Salary: {Salary}");
            }
        }

        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "John Doe", 50000);
            Console.WriteLine($"Employee ID: {employee1.EmployeeID}");
            employee1.FullName = "Jane Doe";
            Console.WriteLine("\nEmployee Information after updating full name:");
            employee1.DisplayEmployeeInfo();

            Console.ReadLine();
        }
    }
}
