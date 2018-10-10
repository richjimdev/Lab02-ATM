using System;

namespace bankATM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal balance = 500.00m;
            while(true)
            {
                Console.WriteLine("Welcome to 401 bank! Select an option.");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");


                try
                {
                    decimal selection = decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please input only positive numbers");
                }

            }
        }

    }
}

