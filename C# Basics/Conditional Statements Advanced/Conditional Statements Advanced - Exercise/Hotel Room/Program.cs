using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int sleep = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var apartment = 0.0;
            var discount = 0.0;
            var totalStudio = 0.0;
            var totalApartment = 0.0;

            switch (month)
            {
                case "may":
                case "october":
                    totalApartment = sleep * 65;
                    totalStudio = sleep * 50;
                    if (sleep > 14)
                    {
                        discount = totalApartment * 0.1;
                        totalApartment -= discount;
                    }
                    if (sleep > 7 && sleep <= 14) 
                    {
                        discount = totalStudio * 0.05;
                        totalStudio -= discount;
                    }
                    else if (sleep > 14)
                    {
                        discount = totalStudio * 0.30;
                        totalStudio -= discount;
                    }                    
                    break;
                case "june":
                case "september":
                    totalApartment = sleep * 68.70;
                    totalStudio = sleep * 75.20;
                    if (sleep > 14)
                    {
                        discount = totalApartment * 0.1;
                        totalApartment -= discount;
                    }
                    if (sleep > 14)
                    {
                        discount = totalStudio * 0.20;
                        totalStudio -= discount;
                    }                
                    break;
                case "july":
                case "august":
                    totalApartment = sleep * 77.00;
                    totalStudio = sleep * 76.00;
                    if (sleep > 14)
                    {
                        discount = totalApartment * 0.1;
                        totalApartment -= discount;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Apartment: {totalApartment:f2} lv.\nStudio: {totalStudio:f2} lv.");
        }
    }
}