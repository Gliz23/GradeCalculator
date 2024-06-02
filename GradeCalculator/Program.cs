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

            Console.Write("Enter a numerical grade (0-100): ");
            int numericalGrade = int.Parse(Console.ReadLine());

       
            string letterGrade;
            if (numericalGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (numericalGrade >= 80)
            {
                letterGrade = "B";
            }
            else if (numericalGrade >= 70)
            {
                letterGrade = "C";
            }
            else if (numericalGrade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine("Your letter grade is: " + letterGrade);
        }
    }
}
