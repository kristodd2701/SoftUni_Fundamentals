namespace _02._CoffeeLover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();
            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                string[] commandParts = Console.ReadLine().Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "Include":
                        IncludeCoffee(coffees, commandParts[1]);
                        break;

                    case "Remove":
                        RemoveCoffees(coffees, commandParts[1], int.Parse(commandParts[2]));
                        break;

                    case "Prefer":
                        PreferCoffees(coffees, int.Parse(commandParts[1]), int.Parse(commandParts[2]));
                        break;

                    case "Reverse":
                        ReverseCoffees(coffees);
                        break;
                }
            }
            Console.WriteLine($"Coffees:\n{string.Join(" ", coffees)}");
        }
        static void IncludeCoffee(List<string> coffees, string coffee)
        {
            coffees.Add(coffee);
        }
        static void RemoveCoffees(List<string> coffees, string position, int numberOfCoffees)
        {
            if (position == "first" && numberOfCoffees <= coffees.Count)
            {
                coffees.RemoveRange(0, numberOfCoffees);
            }
            else if (position == "last" && numberOfCoffees <= coffees.Count)
            {
                coffees.RemoveRange(coffees.Count - numberOfCoffees, numberOfCoffees);
            }
        }
        static void PreferCoffees(List<string> coffees, int index1, int index2)
        {
            if (index1 >= 0 && index1 < coffees.Count && index2 >= 0 && index2 < coffees.Count)
            {
                string temp = coffees[index1];
                coffees[index1] = coffees[index2];
                coffees[index2] = temp;
            }
        }
        static void ReverseCoffees(List<string> coffees)
        {
            coffees.Reverse();
        }
    }
}
