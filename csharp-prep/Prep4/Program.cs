using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // Okay, so what I need to do here is ask the user for a number, connect that question to a 
        // while loop so that it will at least operate once, and add each number entered to a list

        // First things first, create the list:

        List<int> numbers = new List<int>();

        // Introduce the program:
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Now that that's done, time to create the loop
        Console.Write("Please enter a number: ");
        string UserInput = Console.ReadLine();
        int number = int.Parse(UserInput);

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter number: ");
            UserInput = Console.ReadLine();
            number = int.Parse(UserInput);
        }

        // Okay, so what I need to do now is make a running total and print each item in the list out.
        
        // string total = "0";
        int RunningTotal = 0;
        
        int max = 0;
        int min = 999999999;

        Console.WriteLine();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
            RunningTotal += i;
            if (i > max)
            {
                max = i;
            }
            else if (i < min)
            {
                min = i;
            }
        }
        int average = RunningTotal/numbers.Count;

        Console.WriteLine($"\nThe running total is: {RunningTotal}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");
        Console.WriteLine($"The average of all numbers is: {average}");

    }
}