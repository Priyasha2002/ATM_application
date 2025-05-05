using System;

class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    private decimal balance;

    public BankAccount(string accountNumber, string accountHolderName)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        balance = 0; // Assuming the initial balance is 0
    }

    public void Deposit(decimal amount)
    {
        if (amount < 1)
        {
            Console.WriteLine("Deposit amount can't be less than Rs1");
        }
        else
        {
            balance += amount;
            Console.WriteLine($"Deposited amount: {amount}.After depositing your current balance is Rs {balance}");
        }
            
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Your current balance is Rs{balance} after withdrawl");
        }
    }
    public void checkbalance()
    {
        Console.WriteLine($"Account holder name : {accountHolderName}");
        Console.WriteLine($"Account Number : {accountNumber}");
        Console.WriteLine($"Your current balance is Rs{balance}");
    }
}
class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.Clear();
        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Account Number: ");
        string accNum = Console.ReadLine();

        BankAccount account = new BankAccount(accNum, name);
        while (true)
        {
            Console.WriteLine("\n=== Simple Banking System ===");
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");


            Console.WriteLine("Enter your choice :");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter amount to deposit: Rs");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;

                case "2":
                    Console.Write("Enter amount to withdraw: Rs");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;
                case "3":
                    account.checkbalance();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the banking system!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option");
                    break;

            }
        }
    }
}
