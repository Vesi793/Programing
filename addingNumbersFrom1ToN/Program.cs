﻿namespace addingNumbersFrom1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
