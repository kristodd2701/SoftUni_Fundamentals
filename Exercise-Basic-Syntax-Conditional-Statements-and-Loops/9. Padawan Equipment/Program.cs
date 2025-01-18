namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            float lightsaber = float.Parse(Console.ReadLine());
            float robe = float.Parse(Console.ReadLine());
            float belt = float.Parse(Console.ReadLine());

            double precent = (double)countOfStudents * 10 / 100;
            double allSabers = countOfStudents + Math.Ceiling(precent); ;

            double Sabers = lightsaber * allSabers;

            double robes = robe * countOfStudents;

            double allbelts = countOfStudents - Math.Ceiling((double)(countOfStudents / 6));
            double belts = belt * countOfStudents;

            double total = Sabers + robes + belts;
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(total - money):F2}lv more.");
            }

        }
    }
}
