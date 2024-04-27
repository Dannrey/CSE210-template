using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please enter your numeric score: ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);

        // Define if statement:
        string FinalGrade;
        if (grade >= 90)
        {
            if (grade > 93)
            {
                FinalGrade = "A";
            }
            else
            {
                FinalGrade = "A-";
            }
        }
        else if (grade >= 80)
        {
            if (grade > 87)
            {
                FinalGrade = "B+";
            }
            else if (grade > 83)
            {
                FinalGrade = "B";
            }
            else
            {
                FinalGrade = "B-";
            }
        }
        else if (grade >= 70)
        {
            if (grade > 77)
            {
                FinalGrade = "C+";
            }
            else if (grade > 73)
            {
                FinalGrade = "C";
            }
            else
            {
                FinalGrade = "C-";
            }
        }
        else
        {
            FinalGrade = "F";
        }
        
        
        Console.Write($"With a score of {grade}, your grade is {FinalGrade}");

    }
}