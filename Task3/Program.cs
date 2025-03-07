BankAccount account1 = new BankAccount(1000);
account1.Deposit(100);
account1.Withdraw(500);
account1.GetBalance();


public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal amount)
    {
        balance = amount;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            balance -= amount;
        }
    }

    public void GetBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }
}