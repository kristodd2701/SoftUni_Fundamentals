namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");

            double lenght = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");

            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");

            double heigth = double.Parse(Console.ReadLine());

            double volume = (lenght * width * heigth) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
