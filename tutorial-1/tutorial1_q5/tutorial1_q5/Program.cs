using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication Table of {0}:", number);
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine("{0} x {1} = {2}", number, i, result);
            }

            Console.ReadLine();
        }
    }
}
