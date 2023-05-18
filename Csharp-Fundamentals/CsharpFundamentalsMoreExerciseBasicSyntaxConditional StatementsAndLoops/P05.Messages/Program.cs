namespace P05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 0; i < lenght; i++)
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);
                int digit = number % 10;
                int offset = (digit - 2) * 3;
                if (digit == 0)
                {
                    word += " ";
                }
                else if (digit > 7)
                {
                    word += (char)(97 + offset + input.Length);
                }
                else
                {
                    word += (char)(97 + offset + input.Length - 1);
                }
            }
            Console.WriteLine(word);
        }
    }
}