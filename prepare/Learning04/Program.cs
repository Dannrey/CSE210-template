using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Console.Write("Math or literature Danniel? ");
        string choice = Console.ReadLine();
        
        if (choice.ToUpper() == "MATH") {
            MathAssignment math = new MathAssignment();
            math.GetHomeworkList();
        }
        else if (choice.ToUpper() == "LITERATURE") {
            WritingAssignment writing = new WritingAssignment();
            writing.GetWritingInformation();
        }

        
        // Homework.GetSummary();
        




 
    }
}