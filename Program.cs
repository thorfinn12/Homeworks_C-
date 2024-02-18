using System;
using System.Collections.Generic;

public class ATM
{
    private static int balance = 1000;

    //ბარათების ნომრების და PIN კოდების Dictionary
    private static Dictionary<int, int> cardPinMap = new Dictionary<int, int>()
    {
        { 1234567890, 1234 },
        { 1234567790, 1235 },
        { 1122334455, 1122 }
        
    };
    //ამოწმებს ბალანსს ანგარიშზე
    public static void CheckBalance()
    {
        Console.WriteLine($"Your Current Balance is: {balance} $");
    }
    //თანხის შეტანა ანგარიშზე
    public static void Deposit()
    {
        Console.Write("Enter your Deposit amount: ");
        int damount = Convert.ToInt32(Console.ReadLine());
        balance += damount;
        Console.WriteLine("Successfully Deposited");
        Console.WriteLine($"Your current balance is {balance} $");
    }
    //თანხის გამოტანა ანგარიშიდან
    public static void Withdraw()
    {
        Console.Write("Enter the Withdrawal amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Transaction Successful");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    //ვალუტის კონვერტაცია
    public static void ConvertCurrency()
    {
        Console.WriteLine("\nCurrency Conversion:");
        Console.WriteLine("1. Georgian Lari to American Dollar");
        Console.WriteLine("2. Georgian Lari to European Euro");
        Console.WriteLine("3. Back to main menu");
        Console.Write("Select an option (1/2/3): ");
        int conversionOption = Convert.ToInt32(Console.ReadLine());

        switch (conversionOption)
        {
            case 1:
                Console.Write("Enter the amount in Georgian Lari: ");
                double lariAmount = Convert.ToDouble(Console.ReadLine());
                double dollarAmount = lariAmount / 2.6;
                Console.WriteLine($"{lariAmount} GEL is approximately {dollarAmount:F2} USD");
                break;
            case 2:
                Console.Write("Enter the amount in Georgian Lari: ");
                double lariEuroAmount = Convert.ToDouble(Console.ReadLine());
                double euroAmount = lariEuroAmount / 3;
                Console.WriteLine($"{lariEuroAmount} GEL is approximately {euroAmount:F2} EUR");
                break;
            case 3:
                //აბრუნებს მთავარ მენიუში
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
    //პინ კოდის შეცვლა
    public static void ChangePin(int cardNumber)
    {
        Console.Write("Enter your current PIN: ");
        int currentPin = Convert.ToInt32(Console.ReadLine());

        if (cardPinMap.ContainsKey(cardNumber) && cardPinMap[cardNumber] == currentPin)
        {
            Console.Write("Enter your new PIN: ");
            int newPin = Convert.ToInt32(Console.ReadLine());
            cardPinMap[cardNumber] = newPin;
            Console.WriteLine("PIN successfully changed");
        }
        else
        {
            Console.WriteLine("Invalid current PIN.");
        }
    }
    //ტრანზაქციების შესრულება
    public static void PerformTransaction()
    {
        while (true)
        {
            Console.WriteLine("\nEnter 1 for Balance Inquiry");
            Console.WriteLine("Enter 2 for Money Withdrawal");
            Console.WriteLine("Enter 3 for Money Deposit");
            Console.WriteLine("Enter 4 for Currency Conversion");
            Console.WriteLine("Enter 5 for PIN Code Change");
            Console.WriteLine("Enter 6 to Exit");
            Console.Write("Select an option (1/2/3/4/5/6): ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CheckBalance();
                    break;
                case 2:
                    Withdraw();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    ConvertCurrency();
                    break;
                case 5:
                    Console.Write("Enter Your Card Number: ");
                    int cardNumber = Convert.ToInt32(Console.ReadLine());
                    ChangePin(cardNumber);
                    break;
                case 6:
                    Console.WriteLine("Thank you for using the ATM!");
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the ATM!");
            Console.Write("Enter Your Card Number: ");
            int cardNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            //ამოწმებს ბარათის ნომერს და PIN კოდს Dictionary-ში
            if (cardPinMap.ContainsKey(cardNumber) && cardPinMap[cardNumber] == pin)
            {
                PerformTransaction();
            }
            else
            {
                Console.WriteLine("Invalid Card Number or PIN.");
            }
        }
    }
}
