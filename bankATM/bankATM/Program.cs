using System;

namespace bankATM
{
    public class Program
    {
        // Storing balance to be accessed by all methods
        public static decimal balance = 500.00m;

        public static void Main(string[] args)
        {
            //Loop that will run until user decides to exit
            while(true)
            {
                Console.WriteLine("Welcome to 401 bank! Select an option.");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                
                // Multiple blocks of code can cause exceptions therefore I'm adding my code here
                try
                {
                    int selection = int.Parse(Console.ReadLine());
                    if (selection == 1) Console.WriteLine($"Your Balance is ${GetBalance()}");
                    else if (selection == 2)
                    {
                        Console.WriteLine($"How much would you like to withdrawl? Current balance is ${GetBalance()}");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        // This prevents user from withdrawing more than what is available
                        if (ammount <= 0) throw new Exception("NegativeNumberInput");
                        Withdraw(ammount);
                        Console.WriteLine($"Your new balance is now ${ GetBalance() }");

                    }
                    else if (selection == 3)
                    {
                        Console.WriteLine($"How much would you like to deposit? Current balance is ${GetBalance()}");
                        decimal ammount = decimal.Parse(Console.ReadLine());
                        // This prevents user from entering negative numbers for a deposit
                        if (ammount <= 0) throw new Exception("NegativeNumberInput");
                        Deposit(ammount);
                        Console.WriteLine($"Your new balance is now ${ GetBalance() }");
                    }
                    else if (selection == 4) Environment.Exit(0);
                    // If an ivalid choice, will throw an exception
                    else throw new ArgumentException("InvalidATMSelection");
                }
                // Set up my throw and catch statements to do specific tasks depending on the type of exception thrown
                catch (ArgumentException)
                {
                    Console.WriteLine("Please select options 1 - 4 only.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Not enough money available in your account");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only input a positive number");
                }
                finally
                {
                    // Prompts user whether there were errors or not
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

        public static decimal Withdraw(decimal ammount)
        {
            if ((balance - ammount) < 0) throw new IndexOutOfRangeException("NotEnoughMoney");
            return balance = balance - ammount;
        }

        public static decimal Deposit(decimal ammount)
        {
            return balance = balance + ammount;
        }
    }
}

