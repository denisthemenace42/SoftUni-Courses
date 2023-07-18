namespace P02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double britishPound = 1.31;
            Console.WriteLine($"{money * britishPound:f3}");
        }
    }
}