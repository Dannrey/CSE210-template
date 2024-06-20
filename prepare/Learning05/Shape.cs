//Alright, this file will hold the shape class, which will contain the color of the shape. I personally don't agree with how these classes are formatted, but I'll do it anyway.

public abstract class Shape{
    // Attributes:
    protected string _color;


    // Constructors:
    // public Shape(){
        // Console.Write("I can do the area of a square, rectangle, or a circle.\nWhich shall it be? ");
        // string choice = Console.ReadLine();
        // if (choice.ToLower() == "Square"){
        // }
    // }

    
    // Methods:
    public abstract double GetArea();  // This was the only method that was originally supposed to be made, but I inluded the two below to make the program more interactive and to make it work better.
    public abstract string GetShapeType();  // This one is used to determine how 
    public abstract string GetColor();  // This one is purely for cosmetics and so that when a Shape object is called, it will also display the color.
}