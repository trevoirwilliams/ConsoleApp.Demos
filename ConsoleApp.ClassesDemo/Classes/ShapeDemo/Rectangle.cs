using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(double width, double length)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        public override string GetShapeName()
        {
            return "";
        }
    }
}
