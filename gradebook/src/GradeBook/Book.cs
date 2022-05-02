using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }        

        public void AddGrade(double grade)
        {   
            grades.Add(grade);
        }

        public void ShowStats()
        {
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

        private List<double> grades;
        private string name;
    }
}