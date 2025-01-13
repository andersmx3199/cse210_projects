using System;

class Program
{
    static void Main(string[] args)
    {
        // Grade percentage to determine letter grade
        char letter_grade;

        Console.WriteLine("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int grade_number = int.Parse(grade);

        if (grade_number >= 90)
        {
            letter_grade = 'A';
        }

        else if (grade_number >= 80 && grade_number < 90)
        {
            letter_grade = 'B';
        }

        else if (grade_number >= 70 && grade_number < 80)
        {
            letter_grade = 'C';
        }

        else if (grade_number >= 60 && grade_number < 70)
        {
            letter_grade = 'D';
        }

        else
        {
            letter_grade = 'F';
        }

        Console.WriteLine($"You received a[n] {letter_grade} for this class.");


        //Did you pass the class or not?
        if (grade_number >= 70)
        {
            Console.WriteLine("Congrats, you passed the class.");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}