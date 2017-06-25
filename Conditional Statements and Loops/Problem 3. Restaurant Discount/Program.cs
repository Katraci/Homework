using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal totalPrice = 0.0M;
            decimal discount = 0.0M;
            string place = "none";
            if (people > 0 && people <= 50)
            {
                totalPrice += 2500.0M;
                place = "Small Hall";
            }
            else
            {
                if (people > 50 && people <= 100)
                {
                    totalPrice += 5000.0M;
                    place = "Terrace";
                }
                else
                {
                    if (people > 100 && people <= 120)
                    {
                        totalPrice += 7500.0M;
                        place = "Great Hall";
                    }
                }
            }
            if (totalPrice == 0.0M)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (package == "Normal")
                {
                    totalPrice += 500.0M;
                    discount += 0.05M;
                }
                else
                {
                    if (package == "Gold")
                    {
                        totalPrice += 750.0M;
                        discount += 0.1M;
                    }
                    else
                    {
                        if (package == "Platinum")
                        {
                            totalPrice += 1000.0M;
                            discount += 0.15M;
                        }
                    }
                }

                decimal pricePerOne = (totalPrice - (totalPrice * discount)) / people;
                Console.WriteLine($"We can offer you the {place}");
                Console.WriteLine($"The price per person is {pricePerOne:F2}$");
            }
        }
    }
}
