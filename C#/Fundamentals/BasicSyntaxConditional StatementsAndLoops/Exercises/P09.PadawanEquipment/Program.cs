namespace P09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            float priceLS = float.Parse(Console.ReadLine());
            float priceRobes = float.Parse(Console.ReadLine());
            float priceBelts = float.Parse(Console.ReadLine());

            double freeBelts = 0;
            double sabers = Math.Ceiling(countStudents * 1.10);
            int sabers1 = Convert.ToInt32(sabers);

            if (countStudents % 6 == 0)
            {
                freeBelts = countStudents / 6;
            }
            else
            {
                freeBelts = Math.Floor(countStudents / 6.0);
            }
            int freeBelts1 = Convert.ToInt32(freeBelts);
            float totalPrice = ((countStudents - freeBelts1) * priceBelts) + (sabers1 * priceLS) + (countStudents * priceRobes);

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }
        }
    }
}