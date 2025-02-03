
namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(command, count));
        }

        static string RepeatString(string command, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result = string.Concat(Enumerable.Repeat(command, count));
            }
            return result;
        }
    }
}
