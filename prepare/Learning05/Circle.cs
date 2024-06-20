public class Circle : Shape{
    // Attributes:
    private double _radius;


    // Constructors:
    public Circle(){
        Console.Write("What is the color of the circle? ");
        _color = Console.ReadLine();
        // Console.WriteLine();
        Console.Write("What is the length of the radius of the circle? ");
        _radius = double.Parse(Console.ReadLine());
        Console.WriteLine();
        // Console.WriteLine($"The {_color} circle has an area of {GetArea()}");
    }


    // Methods
    public override double GetArea(){
        double Area = _radius*_radius * Math.PI;
        return Area;
    }
    public override string GetShapeType(){
        string ShapeType = "circle";
        return ShapeType; 
    }
    public override string GetColor(){
        return _color;
    }
}