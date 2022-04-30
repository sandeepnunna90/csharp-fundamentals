using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            var grades = new List<double>() { 12.7, 10, 6.11, 4.1, 11.0};
            grades.Add(56.1); 

            // Total Grade
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"Averge Grade: {result:N2}");
            Console.WriteLine($"Lowest Grade: {lowGrade:N2}");
            Console.WriteLine($"Higesht Grade: {highGrade:N2}");
        }
    }
}
