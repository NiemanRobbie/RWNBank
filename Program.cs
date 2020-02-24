using System;
using System.Collections.Generic;
using System.Linq;
using CsvHelper;


namespace RWNBank
{
    class Program
    {
        static void SaveAccounts(List<Accounts> account)
        {
            var writer = new StreamWriter("account.csv");
            var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(account);
            writer.Flush();
            static void Main(string[] args)
            {
                // Greeting to User
                Console.WriteLine("Welcome to RWN Bank");
                Console.WriteLine("Your Account Balance is");

                //As a user I should be able see the totals in my saving and checking account when the program first starts
                var account = new List<Accounts>();

                var isRunning = true;
                while (isRunning)
                {
                    foreach (var accounts in account) ;
                    {
                        Console.WriteLine($"{account.checking} has {account.checkingBal}");
                    }
                    Console.WriteLine("(DEPOSIT), (WITHDRAW) or (TRANFER)");
                    var input = Console.ReadLine().ToLower();

                    //As a user I should be able to deposit funds to my savings account
                    if (input == "deposit")
                    {
                        Console.WriteLine("What is your deposit amount?");
                        var what = Console.ReadLine();

                        tracker.AddANewAccount(sav, chk);
                    }
                    //As a user I should be able to withdraw funds to my savings account
                    else if (input == "withdraw")
                    {
                        Console.WriteLine("What is your withdraw amount?");
                        var withdrawBal = Console.ReadLine();
                        withdrawBal.RemoveAccount();
                    }
                    //As a user I should be able to transfer funds from my checking account to my savings account
                    else if (input == "transfer")
                    {
                        Console.WriteLine("How much do you want to transfer?");
                        var tran = Console.ReadLine();
                        Console.WriteLine("To which account?");
                        var newBal = Console.ReadLine();
                        account.Transfer(chk, newBal);
                    }
                    else if (input == "quit")
                    {
                        isRunning = false;
                    }

                    //The app should save my transactions to file using a standard format. This saving should happen after every transaction
                    SaveAccounts(account);
                    //The app should load up past transaction from a file on start up.    
                }
            }
        }
    }
}
