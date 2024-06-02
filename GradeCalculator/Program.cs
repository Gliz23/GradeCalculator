using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your numerical grade (0-100) and press Enter to view your grade: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                   return;
                }

                if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
                {
                    if (grade >= 90)
                    {
                        Console.WriteLine("Your letter grade is: A");
                    }
                    else if (grade >= 80)
                    {
                        Console.WriteLine("Your letter grade is: B");
                    }
                    else if (grade >= 70)
                    {
                        Console.WriteLine("Your letter grade is: C");
                    }
                    else if (grade >= 60)
                    {
                        Console.WriteLine("Your letter grade is: D");
                    }
                    else
                    {
                        Console.WriteLine("Your letter grade is: F");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number between 0 and 100.");
                }

                Console.WriteLine();
            }
            
        }
    }
}
