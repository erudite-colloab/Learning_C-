// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    class GradeCalculator
{
    static void Main(String[] args)
    {
        Console.WriteLine("________Grade Calculator_________");
        Console.WriteLine();
        Console.WriteLine("Enter your Score: ");
        double score = Convert.ToDouble(Console.ReadLine());
        double gpa;  
        if (score >= 80 && score <= 100)
        {
            Console.WriteLine("Grade: A" );
                
            Console.WriteLine("Excellent");
        }
        else if (score >= 70 && score < 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (score >= 60 && score < 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (score >= 50 && score < 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
            Console.WriteLine("You failed!");
        }


            if (score >= 90)
            {
                gpa = 4.0;
                Console.WriteLine("GPA: " + gpa);
            }
            else if (score >= 80)
            {
                gpa = 3.5;
                Console.WriteLine("GPA: " + gpa);
            }
            else if (score >= 70) { 
                gpa = 3.0;
                Console.WriteLine("GPA: " + gpa);
            }
            else if(score >= 60)
            {
                gpa = 2.0;
                Console.WriteLine("GPA: " + gpa);
            }
            else if(score >= 50)
            {
                gpa = 1.0;
                Console.WriteLine("GPA: " + gpa);
            }
            else
            {
                gpa = 0.0;
                Console.WriteLine("GPA: " + gpa);
            }


    }
}

}
