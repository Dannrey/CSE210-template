public class Square : Shape{
    // Attributes:

    private double _side;


    // Constructors:
    public Square(){
        Console.Write("What is the color of the square? ");
        _color = Console.ReadLine();
        // Console.WriteLine();
        Console.Write("What is the length of one side of the square? ");
        _side = double.Parse(Console.ReadLine());
        Console.WriteLine();
        // Console.WriteLine($"The {_color} square has an area of {GetArea()}");
    }


    // Methods
    public override double GetArea(){
        double Area = _side*_side;
        return Area;
    }
    public override string GetShapeType(){
        string ShapeType = "square";
        return ShapeType; 
    }
    public override string GetColor(){
        return _color;
    }
}