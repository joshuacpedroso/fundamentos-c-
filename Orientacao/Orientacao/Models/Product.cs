using Orientacao.Enum;

namespace Orientacao.Models
{
    public class Produto : Entity
    {
        public Produto(string nome, ProductType tipoproduto)
        {
            NomeProduto = nome;
            ProductType = tipoproduto;
        }
        public ProductType ProductType { get; set; }
        public string NomeProduto { get; set; }
    }
}
