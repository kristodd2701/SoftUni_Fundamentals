
namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnRaisedNumber(baseNumber, power));
        }

        static double ReturnRaisedNumber(double baseNumber, int power)
        {
            double result = Math.Pow(baseNumber, power);
            return result;
        }
    }
}
