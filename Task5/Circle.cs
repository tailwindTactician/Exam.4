public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override void Area()
    {
        double area = Math.PI * Radius * Radius;
        System.Console.WriteLine($"Area of the circle with radius {Radius} is {area}");
    }
}