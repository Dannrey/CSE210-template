using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // So, here is a list full of custome objects. I didn't really know that you could do that until now, although it does make sense if you really think about it.
        List<Shape> shapes = new List<Shape>();

        // This line of code will acquire how many shapes there are:
        Console.Write("How many shapes do you want to enter? ");
        int Response = int.Parse(Console.ReadLine());
        int iteration = 0;

        // This line of code and the following ones will stock the list of custome objects:
        while (iteration != Response){
            Console.Clear();
            iteration += 1;
            Console.WriteLine("Rectangle, circle or square? ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "square"){
                Square square  = new Square();
                shapes.Add(square);
            }
            else if (choice.ToLower() == "circle"){
                Circle circle = new Circle();
                shapes.Add(circle);
            }
            else if (choice.ToLower() == "rectangle"){
                Rectangle rectangle = new Rectangle();
                shapes.Add(rectangle);
            }
            else{
                Console.WriteLine("I'm sorry, you did not enter a valid response.\nPlease enter the statistics for a square instead:");
                Square square = new Square();
                shapes.Add(square);
            }
        }

        /*I made this part of the program somewhat interactive.
        Whereas I designed the program to */
        foreach (Shape shape in shapes){
            if (shape.GetShapeType() == "circle"){
                Console.WriteLine($"The {shape.GetColor().ToLower()} {shape.GetShapeType()} has an area of {shape.GetArea()} inches squared.");
            }
            else if (shape.GetShapeType() == "square"){
                Console.WriteLine($"The {shape.GetColor().ToLower()} {shape.GetShapeType()} has an area of {shape.GetArea()} inches squared.");
            }
            else if (shape.GetShapeType() == "rectangle"){
                Console.WriteLine($"The {shape.GetColor().ToLower()} {shape.GetShapeType()} has an area of {shape.GetArea()} inches squared.");
            }
        }
    }
}