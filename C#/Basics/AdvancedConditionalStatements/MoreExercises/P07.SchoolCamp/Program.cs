using System;

namespace P07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int groupSize = int.Parse(Console.ReadLine());
            int overnightStay = int.Parse(Console.ReadLine());

            string sport = "";
            double price = 0.0;

            switch(season)
            {
                case "Winter":
                    if (groupType == "mixed") 
                    {
                        price = groupSize * 10.00 * overnightStay;
                        sport = "Ski";
                    }
                    else 
                    {
                        switch (groupType)
                        {
                            case "girls":
                                sport = "Gymnastics";
                                    break;
                            case "boys":
                                sport = "Judo";
                                break;
                        }
                            
                        price = groupSize * 9.60 * overnightStay;
                    }
                break;
                case "Summer":
                    if (groupType == "mixed")
                    {
                        price = groupSize * 20.00 * overnightStay;
                        sport = "Swimming";
                    }
                    else
                    {
                        switch (groupType)
                        {
                            case "girls":
                                sport = "Volleyball";
                                break;
                            case "boys":
                                sport = "Football";
                                break;
                        }
                        price = groupSize * 15.00 * overnightStay;
                    }
                    break;
                case "Spring":
                    if (groupType == "mixed")
                    {
                        price = groupSize * 9.50 * overnightStay;
                        sport = "Cycling";
                    }
                    else
                    {
                        switch (groupType)
                        {
                            case "girls":
                                sport = "Athletics";
                                break;
                            case "boys":
                                sport = "Tennis";
                                break;
                        }
                        price = groupSize * 7.20 * overnightStay;
                    }
                    break;
            } if (groupSize >= 50)
            {
                price *= 0.50;
            }
            else if(groupSize >= 20 && groupSize < 50)
            {
                price *= 0.85;
            }
            else if (groupSize >= 10 && groupSize < 20)
            {
                price *= 0.95;
            }

            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
