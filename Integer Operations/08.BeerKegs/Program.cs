namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float volume = 0;
            float biggestVolume = 0;
            string biggestKegModel = "";
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if (biggestVolume < volume)
                {
                    biggestVolume = volume;
                    biggestKegModel = model;
                }
            }
            Console.WriteLine(biggestKegModel);
            
        }
    }
}
