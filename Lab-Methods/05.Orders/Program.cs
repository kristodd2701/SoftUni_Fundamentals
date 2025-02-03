namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Products(product, quantity);
        }

        static void Products(string product, int quantity)
        {
            double price;
            if (product == "coffee")
            {
                price = 1.50;
                Console.WriteLine($"{(price * quantity):F2}");
            }
            else if(product == "water")
            {
                price = 1.00;
                Console.WriteLine($"{(price * quantity):F2}");
            }
            else if (product == "coke")
            {
                price = 1.40;
                Console.WriteLine($"{(price * quantity):F2}");
            }
            else if (product == "snacks")
            {
                price = 2.00;
                Console.WriteLine($"{(price * quantity):F2}");
            }
        }
    }
}
