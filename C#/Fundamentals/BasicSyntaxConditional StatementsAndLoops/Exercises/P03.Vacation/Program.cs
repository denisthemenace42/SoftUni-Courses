namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = peopleCount * 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = peopleCount * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        price = peopleCount * 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = peopleCount * 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = peopleCount * 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price = peopleCount * 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = peopleCount * 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = peopleCount * 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = peopleCount * 22.50;
                    }
                    break;

            }
            if (peopleCount >= 30 && type == "Students")
            {
                price *= 0.85;
            }
            else if (peopleCount >= 100 && type == "Business")
            {
                if (day == "Friday")
                {
                    price -= 10 * 10.90;
                }
                else if (day == "Saturday")
                {
                    price -= 10 * 15.60;
                }
                else if (day == "Sunday")
                {
                    price -= 10 * 16;
                }
            }
            else if (peopleCount >= 10 && peopleCount <= 20 && type == "Regular")
            {
                price *= 0.95;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}