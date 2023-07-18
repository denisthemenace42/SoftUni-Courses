namespace P04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] stringText = text.ToCharArray();
            Array.Reverse(stringText);
            string reversedText = new string(stringText);
            Console.WriteLine(reversedText);
        }
    }
}