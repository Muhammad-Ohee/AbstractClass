//Console.WriteLine("Hello, OS");

namespace CalculateTheArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OS");

            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

            Triangle triangle = new Triangle(15, 25);
            Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");

            Circle circle = new Circle(12);
            Console.WriteLine($"Area of Circle: {Math.Round(circle.GetArea(), 2)}");

            Cone cone = new Cone(5, 15);
            Console.WriteLine($"Area of Cone: {Math.Round(cone.GetArea(), 2)}");
        }
    }

    public abstract class Shape
    {
        public double Height;
        public double Width;
        public double Radius;
        public const float PI = 3.14f;

        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public Rectangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }
    }

    public class Circle : Shape
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return PI * this.Radius * this.Radius;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double GetArea()
        {
            return (this.Height * this.Width) / 2;
        }
    }

    public class Cone : Shape
    {
        public Cone(double Height, double Radius)
        {
            this.Height = Height;
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return PI * Radius * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius)));
        }
    }
}