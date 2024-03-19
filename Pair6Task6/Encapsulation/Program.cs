//Encapsulation(kapsülleme), nesne yönelimli programlama (OOP) prensiplerinden biridir ve bir sınıfın verilerini ve işlevselliğini 
//bir arada tutmayı amaçlar. Bu, sınıfın içindeki verilerin (alanlar veya özellikler) ve işlevlerin (metotlar veya davranışlar) 
//başka kod parçalarından gizlenmesini ve sadece belirli bir arayüz üzerinden erişilebilir olmasını sağlar. Böylece, sınıfın iç 
//yapısı dış dünyaya gizlenir ve sadece belirli bir şekilde etkileşim sağlanır.

//Encapsulation'ın anahtar faydalarından biri, sınıfın iç detaylarının değişmesi durumunda dış dünyayı etkilememesidir. Bu, kodun 
//daha bakımı kolay hale gelir ve daha az hata ile daha az bağımlılık yaratır.

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
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
        BankAccount account = new BankAccount("123456789", 1000);

        account.Deposit(500);
        Console.WriteLine("Current balance: " + account.GetBalance());

        account.Withdraw(200);
        Console.WriteLine("Current balance: " + account.GetBalance());
    }
}

