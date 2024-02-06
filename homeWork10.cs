using System;

namespace homeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ბანკისა და მიკროფინანსის კლასების ობიექტების ინსტანტირება და მათი მეთოდების გამოყენება
            Bank bank = new Bank();
            double loanAmountBank = bank.CalculateLoanPercent(12, 1000);
            bool bankHistory = bank.CheckUserHistory();
            Console.WriteLine($"Bank loan amount: {loanAmountBank}, User history: {bankHistory}");

            MicroFinance microFinance = new MicroFinance();
            double loanAmountMicroFinance = microFinance.CalculateLoanPercent(12, 1000);
            bool microFinanceHistory = microFinance.CheckUserHistory();
            Console.WriteLine($"MicroFinance loan amount: {loanAmountMicroFinance}, User history: {microFinanceHistory}");
        }
    }

    
    public abstract class FileWorker
    {
        protected int maxFileSize;
        protected string fileExtension;

        public FileWorker(int maxFileSize, string fileExtension)
        {
            this.maxFileSize = maxFileSize;
            this.fileExtension = fileExtension;
        }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();
    }

    
    public interface FinanceOperations
    {
        double CalculateLoanPercent(int month, double amountPerMonth);
        bool CheckUserHistory();
    }

    // class Bank ახორციელებს FinanceOperations ინტერფეისს
    public class Bank : FinanceOperations
    {
        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double interestRate = 0.05; // 5%
            return amountPerMonth * month * (1 + interestRate);
        }

        public bool CheckUserHistory()
        {
            Random rand = new Random();
            return rand.Next(2) == 0; // Randomly returns true or false
        }
    }

    // Class MicroFinance ახორციელებს FinanceOperations ინტერფეისს
    public class MicroFinance : FinanceOperations
    {
        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double commissionRate = 0.1; // 10%
            double totalAmount = amountPerMonth * month;
            double commission = totalAmount * commissionRate;
            return totalAmount + commission;
        }

        public bool CheckUserHistory()
        {
            return true; // Always returns true for MicroFinance
        }
    }
}
