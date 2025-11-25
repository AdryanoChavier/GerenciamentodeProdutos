using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.AdicionarProduto
{
    public class AdicionarProdutoCommand : IRequest
    {
        public Guid ProdutoId { get; set; }
        public int QuantidadeEntrada { get; set; }
    }
}
