namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = byte.MaxValue;
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                sum = sum + quantity;
                if (sum > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantity;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
