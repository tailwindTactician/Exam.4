public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public override void Area()
    {
        double area = Length * Width;
        System.Console.WriteLine($"Area of the rectangle with length {Length} and width {Width} is {area}");
    }
}