﻿namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number = number / 10;
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
