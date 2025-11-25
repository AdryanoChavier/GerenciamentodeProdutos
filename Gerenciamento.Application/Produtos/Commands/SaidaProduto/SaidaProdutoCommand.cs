using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.SaidaProduto
{
    public class SaidaProdutoCommand : IRequest
    {
        public Guid ProdutoId { get; set; }
        public int QuantidadeSaida { get; set; }
    }
}
