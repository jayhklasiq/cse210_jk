using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage(%): ");
        string gradePercent = Console.ReadLine();
        int userGrade = int.Parse(gradePercent);

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
            
        if (userGrade >= 70)
        {
            Console.WriteLine($"Your grade is {letter}. You passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}. Sorry. You didn't pass this course.");
        }
    }
}
