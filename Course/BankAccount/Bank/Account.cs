using System;
using System.Security.Cryptography;

namespace Bank;

public class Account
{
    private string Name { get; set; }

    public int AccountNumber { get; private set; }

    private double Balance { get; set; }

    public Account(string name, int accountNumber)
    {
        Name = name;
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void AddBalance(double value)
    {
        Balance += value;
    }

    public void RemoveBalance(double value)
    {
        Balance -= value;
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }

    

    public override string ToString()
    {
        return "Conta " + AccountNumber +
        ", Titular: " + Name +
        ", Saldo: $ " + Balance.ToString("F2");
    }

}
