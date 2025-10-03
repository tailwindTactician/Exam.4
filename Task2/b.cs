//Можно ли иметь несколько блоков catch в C#? Приведите пример. c)
// Да, в C# можно иметь несколько блоков catch для обработки различных типов исключений.
// Вот пример:

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
        
