namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandParts = command.Split();
                string action = commandParts[0];

                switch (action)
                {
                    case "Add":
                        int numberAdd = int.Parse(commandParts[1]);
                        numbers.Add(numberAdd);
                        break;

                    case "Remove":
                        int numberRemove = int.Parse(commandParts[1]);
                        numbers.Remove(numberRemove);
                        break;

                    case "RemoveAt":
                        int indexRemoveAt = int.Parse(commandParts[1]);
                        numbers.RemoveAt(indexRemoveAt);
                        break;

                    case "Insert":
                        int numberInsert = int.Parse(commandParts[1]);
                        int indexInsert = int.Parse(commandParts[2]);
                        numbers.Insert(indexInsert, numberInsert);
                        break;

                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
