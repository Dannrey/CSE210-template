public class Rectangle : Shape{
    // Attributes:
    private double _length;
    private double _width;


    // Constructors:
    public Rectangle(){
        Console.Write("What is the color of the rectangle? ");
        _color = Console.ReadLine();
        // Console.WriteLine();
        Console.Write("What is the length of the rectangle? ");
        _length = double.Parse(Console.ReadLine());
        // Console.WriteLine();
        Console.Write("What is the width of the rectangle? ");
        _width = double.Parse(Console.ReadLine());
        Console.WriteLine();
        // Console.WriteLine($"The {_color} rectangle has an area of {GetArea()}");
    }


    // Methods
    public override double GetArea(){
        double Area = _length*_width;
        return Area;
    }
    public override string GetShapeType(){
        string ShapeType = "rectangle";
        return ShapeType; 
    }
    public override string GetColor(){
        return _color;
    }
}