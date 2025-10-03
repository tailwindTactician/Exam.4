
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a / b;
    Console.WriteLine(result);
        }
catch (FormatException)
{
    Console.WriteLine("Input format is incorrect.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Division by zero is not allowed.");
}
        