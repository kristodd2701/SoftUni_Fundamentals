namespace _03.TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int entryPointValue = priceRatings[entryPoint];

            int leftSum = CalculateLeftSum(priceRatings, entryPoint, type, entryPointValue);
            int rightSum = CalculateRightSum(priceRatings, entryPoint, type, entryPointValue);

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static int CalculateRightSum(List<int> priceRatings, int entryPoint, string type, int entryPointValue)
        {
            int rightSum = 0;
            for (int i = entryPoint + 1; i < priceRatings.Count; i++)
            {
                if (type == "cheap" && priceRatings[i] < entryPointValue)
                {
                    rightSum += priceRatings[i];
                }
                else if (type == "expensive" && priceRatings[i] >= entryPointValue)
                {
                    rightSum += priceRatings[i];
                }
            }

            return rightSum;
        }

        static int CalculateLeftSum(List<int> priceRatings, int entryPoint, string type, int entryPointValue)
        {
            int leftSum = 0;
            for (int i = 0; i < entryPoint; i++)
            {
                if (type == "cheap" && priceRatings[i] < entryPointValue)
                {
                    leftSum += priceRatings[i];
                }
                else if (type == "expensive" && priceRatings[i] >= entryPointValue)
                {
                    leftSum += priceRatings[i];
                }
            }

            return leftSum;
        }
    }
}
