namespace P12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int a = 1; a <= number; a++)
            {
                int sumOfDigits = 0;
                int digit = a;
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{a} -> True");
                }
                else
                {
                    Console.WriteLine($"{a} -> False");
                }
                
            }
;
        }
    }
}