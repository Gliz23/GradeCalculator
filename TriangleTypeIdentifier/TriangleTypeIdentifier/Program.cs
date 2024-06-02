using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("What are the lengths of the three sides of the triangle?");
                
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return;
                }
                string[] sideLengths = input.Split();

                if (sideLengths.Length != 3 || !int.TryParse(sideLengths[0], out int a) || !int.TryParse(sideLengths[1], out int b) || !int.TryParse(sideLengths[2], out int c))

                {
                Console.WriteLine("Please enter 3 positive integers for the side lengths: ");
                continue;
                }

                string triangleType;

                if (a == b && b == c)
                {
                    triangleType = "Equilateral";
                }
                else if (a == b || b == c || a == c)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }
                Console.WriteLine($"The triangle is {triangleType}.");
                
                Console.ReadLine();

                Console.WriteLine();
            }
        }
    }
}
