namespace P10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (Char.IsLower(symbol))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(symbol))
                    {
                Console.WriteLine("upper-case");
            }
        }
    }
}