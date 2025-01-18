namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;
            double expenses = 0;


            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount += 1;
                }
                if (i % 3 == 0)
                {
                    mouseCount += 1;
                }
                if(i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }
            expenses = headsetCount*headsetPrice +
                mouseCount*mousePrice
                + keyboardCount*keyboardPrice+
                displayCount*displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

        }
    }
}
