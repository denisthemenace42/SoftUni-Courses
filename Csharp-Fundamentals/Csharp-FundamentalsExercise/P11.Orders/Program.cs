namespace P11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 0; i < orderCount; i++)
            {
               double capsulePrice = double.Parse(Console.ReadLine());
               int days = int.Parse(Console.ReadLine());
               int capusleCount = int.Parse(Console.ReadLine());
               double price = capsulePrice * days * capusleCount;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}