namespace P09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdInput = char.Parse(Console.ReadLine());
            string concatenatedString = $"{firstInput}{secondInput}{thirdInput}";
            Console.WriteLine(concatenatedString);
        }
    }
}