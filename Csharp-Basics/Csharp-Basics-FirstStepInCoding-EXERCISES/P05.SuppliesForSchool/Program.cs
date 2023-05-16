using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се отпечата на конзолата колко пари ще са нужни на Ани, за да си плати сметката.
            int amountPens = int.Parse(Console.ReadLine());
            int amountMarkers = int.Parse(Console.ReadLine());
            int litersChemicals = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pens = 5.80;
            double markers = 7.20;
            double chemicalPerLitre = 1.20;
            

            double priceWithoutDiscount = (amountPens * pens) + (amountMarkers * markers) + (litersChemicals * chemicalPerLitre);
            double priceWithDiscount = priceWithoutDiscount - (priceWithoutDiscount * discount / 100);

            
            Console.WriteLine(priceWithDiscount);
        }
    }
}
