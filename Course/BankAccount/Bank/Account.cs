using System;
using System.Security.Cryptography;

namespace Bank;

public class Account
{
    private string Name { get; set; }

    private int AccountNumber { get; set; }

    private double Balance { get; set; }

    public Account(string name, int accountNumber)
    {
        Name = name;
        AccountNumber = accountNumber;
    }

    public void AddBalance(double value)
    {
        Balance += value;
    }

    public void RemoveBalance(double value)
    {
        Balance -= value;
    }

}
