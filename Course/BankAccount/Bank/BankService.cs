using System;

namespace Bank;

public class BankService
{
    private Dictionary<int, Account> Accounts { get;  set; } = new();
    public Account NewAccount(string name, int accountNumber)
    {
        Account newAccount =  new(name, accountNumber);
        Accounts.Add(newAccount.AccountNumber, newAccount);
        return Accounts.GetValueOrDefault(newAccount.AccountNumber);
    }

    public string showAccount(int accountNumber)
    {
        return Accounts.GetValueOrDefault(accountNumber).ToString();
    }

    public bool addBalance(int accountNumber, double value)
    {
        Accounts.GetValueOrDefault(accountNumber).AddBalance(value);
        return true;
    }

        public bool RemoveBalance(int accountNumber, double value)
    {
        Accounts.GetValueOrDefault(accountNumber).RemoveBalance(value);
        // fee
        Accounts.GetValueOrDefault(accountNumber).RemoveBalance(5);

        return true;
    }
}
