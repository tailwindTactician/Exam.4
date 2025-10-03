public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    public void Drive()
    {
        System.Console.WriteLine($"Driving a {Brand} {Model} {Year} ");
    }
}