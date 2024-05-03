using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        // So, first I need to create a function to print to the screen: "Welcome to the program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Acquire the user's name:
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Ask the user their favorite number:
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Get a number from the user to square:
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        // Now to display the final results to the user:
        static void DisplayResult()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int SquaredNumber = SquareNumber(number);

            Console.WriteLine($"{name}, the square of your number is {SquaredNumber}.");
        }
        DisplayResult();
    }
}