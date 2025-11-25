using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.UpdateProduto
{
    public class UpdateProdutoCommand : IRequest
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
