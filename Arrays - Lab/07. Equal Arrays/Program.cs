using System.Diagnostics.CodeAnalysis;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int[] numbers1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int sum = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers[i] != numbers1[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                sum += numbers[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");



        }
    }
}
