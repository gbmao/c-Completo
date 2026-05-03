// See https://aka.ms/new-console-template for more information
using Bank;

BankService bankService = new BankService();

System.Console.Write("Entre o número da conta: ");
int accountNumber = int.Parse(Console.ReadLine());
System.Console.Write("Entre o títular da conta: ");
string name = Console.ReadLine();

bankService.NewAccount(name, accountNumber);



System.Console.Write("Haverá depósito inicial (s/n)? ");
string response = Console.ReadLine();

if (response == "s")
{
    System.Console.Write("Entre o valor do depósito inicial: ");
    double value = double.Parse(Console.ReadLine());
    bankService.addBalance(accountNumber, value);
}

System.Console.WriteLine(bankService.showAccount(accountNumber));

System.Console.Write("Entre um valor para depósito: ");
double deposit = double.Parse(Console.ReadLine());
bankService.addBalance(accountNumber, deposit);
System.Console.WriteLine("Dados da conta atualizado:");
System.Console.WriteLine(bankService.showAccount(accountNumber));

System.Console.Write("Entre um valor para saque: ");
deposit = double.Parse(Console.ReadLine());
bankService.RemoveBalance(accountNumber, deposit);
System.Console.WriteLine("Dados da conta atualizado:");
System.Console.WriteLine(bankService.showAccount(accountNumber));