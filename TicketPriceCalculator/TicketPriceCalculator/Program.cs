using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your age please: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return;
                }

                int age;



                if (int.TryParse(Console.ReadLine(), out age))
                {
                    double ticketPrice;
                    if (age <= 12 || age >= 65)
                    {
                        ticketPrice = 7.0;
                        Console.WriteLine($"The price of your ticket is GHC{ticketPrice}.");
                    }
                    else
                    {
                        ticketPrice = 10.0;
                        Console.WriteLine($"THe price of your ticket is GHC{ticketPrice}.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid age");
                }
            }
        }
    }
}