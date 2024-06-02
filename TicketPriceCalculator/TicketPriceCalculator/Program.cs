using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double ticketPrice;

            Console.Write("Enter your age please: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
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