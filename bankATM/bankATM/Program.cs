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

                bool skipFinally = false;


                try
                {
                    int selection = int.Parse(Console.ReadLine());
                    if (selection == 1) Console.WriteLine($"Your Balance is {GetBalance()}");
                    else if (selection == 2)
                    {
                        Console.WriteLine($"How much would you like to withdrawl? Current balance is {GetBalance()}");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        if (ammount <= 0) throw new Exception("NegativeNumberInput");
                    }
                    else if (selection == 4) Environment.Exit(0);
                    else throw new ArgumentException("InvalidATMSelection");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Please select options 1 - 4 only.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please only input a positive number");
                }
                finally
                {
                    Console.WriteLine("Would you like to perform another transaction? y/n:");
                    string userAnswer = Console.ReadLine().ToLower();
                    while (userAnswer != "y")
                    {
                        if (userAnswer == "n")
                            Environment.Exit(0);
                        else Console.WriteLine("Please only enter y or n:");
                        userAnswer = Console.ReadLine().ToLower();
                    }

                }

            }

        }

        public static decimal GetBalance()
        {
            return balance;
        }
    }
}

