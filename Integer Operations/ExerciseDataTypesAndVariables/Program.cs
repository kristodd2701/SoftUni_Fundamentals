namespace ExerciseDataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int add = firstNum + secondNum;
            int devide = add / thirdNum;
            int multiply = devide * fourthNum;

            Console.WriteLine(multiply);
        }
    }
}
