using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Okay, so, first things first, I need to create an instance of the random class to randomly determine
        // The magic number for this game.
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1,100);



        // Console.Write("What is the magic number? ");
        // string MagicNumber1 = Console.ReadLine();
        // MagicNumber = int.Parse(MagicNumber1);
        Console.WriteLine($"{MagicNumber}");

        // These lines are to translate
        Console.Write("What is your guess? ");
        string UserInput = Console.ReadLine();
        int guess = int.Parse(UserInput);
        
        while (guess != MagicNumber)
        {
            if (guess > MagicNumber)
            {
                Console.WriteLine($"Sorry, {guess} is too high. Please try something lower.");
                Console.Write("What is your guess? ");
                UserInput = Console.ReadLine();
                guess = int.Parse(UserInput);
            }
            else
            {
                Console.WriteLine($"Sory, {guess} is too low. Please try something higher.");
                Console.Write("What is your guess? ");
                UserInput = Console.ReadLine();
                guess = int.Parse(UserInput);
            }
        }
        Console.WriteLine($"Congratulations! The answer is {guess}!");
        Console.WriteLine("End game.");
    }
}