namespace TheBiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int competingFactoryProduction = int.Parse(Console.ReadLine());

            // Calculate total production for 30 days
            int total = 0;
            for (int day = 1; day <= 30; day++)
            {
                double dailyProduction = biscuitsCount * workersCount;
                if (day % 3 == 0)
                {
                    dailyProduction *= 0.75;
                }
                total += (int)Math.Floor(dailyProduction);
            }

            Console.WriteLine($"You have produced {total} biscuits for the past month.");

            double percentageDifference;
            if (total > competingFactoryProduction)
            {
                percentageDifference = ((double)(total - competingFactoryProduction) / competingFactoryProduction) * 100;
                Console.WriteLine($"You produce {percentageDifference:F2} percent more biscuits.");
            }
            else
            {
                percentageDifference = ((double)(competingFactoryProduction - total) / competingFactoryProduction) * 100;
                Console.WriteLine($"You produce {percentageDifference:F2} percent less biscuits.");
            }
        }
    }
}
