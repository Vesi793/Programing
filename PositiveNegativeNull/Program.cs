﻿namespace PositiveNegativeNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number is negative.");
            }
            else
            {
                Console.WriteLine($"The number is zero.");
            }
        }
    }
}
