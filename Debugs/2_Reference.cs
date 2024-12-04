class Account
{
    public int Amount { get; set; }
}

public class Reference
{
    public static void Run()
    {
        var account = new Account() { Amount = 10 };

        Console.WriteLine(account.Amount);

        Process(account);

        Console.WriteLine(account.Amount);
    }

    private static void Process(Account account)
    {
        // account = new Account() { Amount = 20 };

        account.Amount = 30;

        Console.WriteLine(account.Amount);
    }
}