BankAccount ac = new BankAccount (1, 130,AccountType.Savings );
BankAccount ac1 = new BankAccount ( 2, 700, AccountType.Checking );
ac.Withdraw(600); 
ac1.Withdraw(200);
class BankAccount
{
    private int AccountNumber;
    private decimal Balance;
    private AccountType Type;
    public BankAccount(int a, decimal b, AccountType c)
    {
        AccountNumber = a;
        Balance = b;
        Type = c;
    }
    public void Withdraw(decimal amount)
    {
        int g = 1;
        try
        {
            if (amount > Balance)
            {
                System.Console.WriteLine(g / 0);
            }
            else
            {
                Balance -= amount;
                System.Console.WriteLine("Withdraw done successfully");
            }
        }
        catch
        {
            System.Console.WriteLine("Amount upper than balance");
        }
    }

}


enum AccountType
{
    Savings,
    Checking
}