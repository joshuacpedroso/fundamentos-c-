using Orientacao.Enum;
using Orientacao.Models;

namespace Orientacao.Class
{
    public class ProductInsert
    {
        static List<Produto> listaProdutos = new List<Produto>();
        public void InserirProduto()
        {
            Console.WriteLine("-- Inserir novo produto --");



            Console.WriteLine("Digite o nome do produto: ");
            var nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite 1 para produto Digital e 2 para Físico ");
            var tipoProduto = int.Parse(Console.ReadLine());

        }
    }
}
