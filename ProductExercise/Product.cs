using System;

namespace ProductExercise;

public class Product
{
    public string name;
    public double price;
    public int quantity;

    public double ValorTotalEmEstoque()
    {
        return (double) quantity * price;
    }

    public void AdicionarProdutos(int quant)
    {
        quantity += quant;
    }

    public void RemoverProdutos(int quant)
    {
        quantity -= quant;
    }

    public void ShowProduct()
    {
        System.Console.WriteLine($"Dados do produto: {name}, ${price}, {quantity} unidades, Total: {ValorTotalEmEstoque().ToString("F2")}");
    }

    public void ShowAtualization()
    {
       System.Console.WriteLine($"Dados atualizados: {name}, ${price}, {quantity} unidades, Total: {ValorTotalEmEstoque().ToString("F2")}");
    }

    public override string ToString()
    {
        return     $"Dados do produto: {name}, ${price}, {quantity} unidades, Total: {ValorTotalEmEstoque().ToString("F2")}";

    }
}
