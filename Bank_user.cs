using System;


class BankUser
{
    public string UserName { get; set; }
    public string Aadhar_number { get; set; }
    public string Account_number { get; private set; }
    public string ATm_pin { get; set; }

    public BankUser(string name, string aadhar, string account)
    {
        UserName = name;
        Aadhar_number = aadhar;
        Account_number = account;
        ATm_pin = GeneratePin();
    }
    private string GeneratePin()
    {
        Random rnd = new Random();
        return rnd.Next(1000, 9999).ToString();
    }
    public void DisplayUserDetails()
    {
        Console.WriteLine("\n=== User Details ===");
        Console.WriteLine($"Name: {UserName}");
        Console.WriteLine($"Aadhaar Number: {Aadhar_number}");
        Console.WriteLine($"Account Number: {Account_number}");
        Console.WriteLine($"ATM Pin: {ATm_pin}");
    }

    public class Program
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Yellow; 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Enter your details:");
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Console.Write("Enter Aadhar number:");
            string aadhar = Console.ReadLine();
            Console.Write("Enter account number:");
            string account = Console.ReadLine();

            BankUser user = new BankUser(name, aadhar, account);

            Console.WriteLine("\n=== Your Data ===");
            user.DisplayUserDetails();
        }
    }

}
