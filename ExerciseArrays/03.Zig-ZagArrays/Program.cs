﻿namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isFirstSelected = true;
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersAsArray = numbers.Split();
                if (isFirstSelected)
                {
                    firstArr[i] = numbersAsArray[0];
                    secondArr[i] = numbersAsArray[1];
                }
                else
                {
                    firstArr[i] = numbersAsArray[1];
                    secondArr[i] = numbersAsArray[0];
                }

                isFirstSelected = !isFirstSelected;
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
