using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace CSharpAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<decimal>());
                }

                studentGrades[studentName].Add(grade);
            }

            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine($"{studentGrade.Key} -> {string.Join(" ", studentGrade.Value.Select(x=>$"{x:f2}").ToList())} (avg: {studentGrade.Value.Average():f2})");
            }
        }
    }
}