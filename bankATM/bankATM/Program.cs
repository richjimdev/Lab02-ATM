using System;

namespace bankATM
{
    public class Program
    {
        public static decimal balance = 500.00m;

        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Welcome to 401 bank! Select an option.");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");


                try
                {
                    int selection = int.Parse(Console.ReadLine());
                    if (selection == 1) Console.WriteLine($"Your Balance is {GetBalance()}");
                    if (selection == 4) break;
                }
                catch
                {
                    Console.WriteLine("Please select 1 - 4 only.");
                }

            }

        }

        public static decimal GetBalance()
        {
            return balance;
        }
    }
}

