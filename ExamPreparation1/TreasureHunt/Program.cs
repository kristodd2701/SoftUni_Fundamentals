namespace TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split("|").ToList();
            string command;

            while ((command = Console.ReadLine()) != "Yohoho")
            {
                string item = Console.ReadLine();
                if (command == "Loot")
                {
                    if (!loot.Contains(item))
                    {
                        loot.Insert(0,item);
                    }
                }

                if (command == "Drop")
                {

                }
            }

        }
    }
}
