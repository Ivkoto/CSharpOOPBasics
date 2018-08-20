using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input;
        var accounts = new Dictionary<int, BankAccount>();

        while ((input = Console.ReadLine())!= "End")
        {
            var cmdArgs = input.Split(' ');

            switch (cmdArgs[0])
            {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, accounts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, accounts);
                    break;
                case "Print":
                    Print(cmdArgs ,accounts);
                    break;
            }
        }
        
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[id].ToString());
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var withdrawAmount = double.Parse(cmdArgs[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance < withdrawAmount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Withdraw(withdrawAmount);
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var depositAmount = double.Parse(cmdArgs[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(depositAmount);
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts[id] = acc;
        }
    }
}