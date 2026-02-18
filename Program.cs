using System;
using System.Collections.Generic;

namespace GradeCalculatorApp
{
    class Program
    {
        // 1. COLLECTION: Used to manage program complexity
        static List<double> gradeList = new List<double>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== AP CSP Grade Calculator ===");
            Console.WriteLine("Instructions: Enter scores one by one.");
            Console.WriteLine("Type 'calculate' to calculate your final grade.");
            Console.WriteLine("---------------------------------------");

            while (true)
            {
                Console.Write("Enter Score: ");
                string input = Console.ReadLine().ToLower();

                if (input == "calculate")
                {
                    // 2. PROCEDURE CALL: Calling the student-defined procedure
                    if (gradeList.Count > 0) {
                        string result = CalculateFinalGrade(gradeList);
                        Console.WriteLine("\n" + result);
                    } else {
                        Console.WriteLine("No grades were entered.");
                    }
                    break; 
                }
                
                // 3. INPUT: Taking data from the user
                if (double.TryParse(input, out double score))
                {
                    gradeList.Add(score);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'calculate'.");
                }
            }
            Console.WriteLine("\nPress Enter to close...");
            Console.ReadLine();
        }

        // ---------------------------------------------------------
        // STUDENT-DEFINED PROCEDURE (For Component C)
        // ---------------------------------------------------------
        public static string CalculateFinalGrade(List<double> scores)
        {
            double total = 0;

            // 4. ITERATION: Loop through the collection
            foreach (double s in scores)
            {
                total += s;
            }

            double average = total / scores.Count;
            string letterGrade = "";

            // 5. SELECTION: Logic to determine the grade
            if (average >= 90) { letterGrade = "A"; }
            else if (average >= 80) { letterGrade = "B"; }
            else if (average >= 70) { letterGrade = "C"; }
            else if (average >= 60) { letterGrade = "D"; }
            else { letterGrade = "F"; }

            return $"Average: {average:F1}% | Letter Grade: {letterGrade}";
        }
    }
}