//a) Дайте определение инкапсуляции своими словами и приведите пример на C#.
// Инкапсуляция - это принцип объектно-ориентированного
// программирования, который объединяет данные и методы, 
//работающие с этими данными, в одном классе. Это позволяет скрыть внутренние детали
// реализации и защитить данные от прямого доступа извне, предоставляя только необходимые 
//интерфейсы для взаимодействия с объектом.
// Пример на C#:
public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine($"Current balance: {account.GetBalance()}");
    }
}