using System.Runtime.CompilerServices;

namespace _02._PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal rate = 1.31m;
            decimal result = britishPounds * rate;
            Console.WriteLine($"{result:F3}");
        }
    }
}
