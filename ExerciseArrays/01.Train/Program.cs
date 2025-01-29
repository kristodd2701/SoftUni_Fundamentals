using System.Diagnostics.CodeAnalysis;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int passenger = int.Parse (Console.ReadLine());
                numbers[i] = passenger;
                sum += passenger;
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(sum);
        }
    }
}
