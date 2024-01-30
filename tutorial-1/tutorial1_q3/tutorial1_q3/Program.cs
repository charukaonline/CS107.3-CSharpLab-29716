using System;

namespace tutorial1_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Sum of numbers from 1 to {0} is {1}", number, sum);
            }
        }
    }
}
