namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo;

public class Square : Polygon
{
    public Square(int width)
    {
        Width = width;
    }
    public override double Area()
    {
        // Math.Pow(Width, 2);
        return Width * Width;
    }
}
