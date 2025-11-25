using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.CreateProduto
{
    public class CreateProdutoCommand : IRequest
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
