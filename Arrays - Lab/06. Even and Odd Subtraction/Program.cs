namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int sum1 = 0;
            int sum2 = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum1 += number;
                }
                else if (number % 2 == 1)
                {
                    sum2 += number;
                }
            }
            Console.WriteLine(sum1 - sum2);
        }
    }
}
