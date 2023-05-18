namespace P10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3 ;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = lostGames/12;
            float headsetPrice = float.Parse(Console.ReadLine())*trashedHeadset;
            float mousePrice = float.Parse(Console.ReadLine())*trashedMouse;
            float keyboardPrice = float.Parse(Console.ReadLine())*trashedKeyboard;
            float displayPrice = float.Parse(Console.ReadLine())*trashedDisplay;
            float expenses = headsetPrice+mousePrice+keyboardPrice+displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}