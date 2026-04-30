// See https://aka.ms/new-console-template for more information
using ProductExercise;

namespace Programsss
{
    class Program
    {
         static void Main(string[] args)
    {
        Product produto = new Product();
        System.Console.WriteLine("Entre os dados do produto: ");

        Console.Write("Nome:");
        produto.name = Console.ReadLine();

        System.Console.Write("Preço:");
        produto.price = double.Parse(Console.ReadLine());

        System.Console.Write("Quantidade em estoque: ");
        produto.quantity = int.Parse(Console.ReadLine());

        System.Console.WriteLine(produto.ToString());

        System.Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
        produto.AdicionarProdutos(int.Parse(Console.ReadLine()));

        produto.ShowAtualization();

        System.Console.Write("Digite o número de produtos a ser removido ao estoque:");
        produto.RemoverProdutos(int.Parse(Console.ReadLine()));

        produto.ShowAtualization();
    }
    }
   
}


