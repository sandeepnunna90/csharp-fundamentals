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
            foreach(var number in grades)
            {
                result += number;
            }
            Console.WriteLine($"Total Grade: {result:N2}");

            // Average Grade
            var average = result / grades.Count;
            Console.WriteLine($"Averge Grade: {average:N3}");
        }
    }
}
