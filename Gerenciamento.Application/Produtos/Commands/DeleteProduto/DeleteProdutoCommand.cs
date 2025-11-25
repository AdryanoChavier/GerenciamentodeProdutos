using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.DeleteProduto
{
    public class DeleteProdutoCommand(Guid id) : IRequest
    {
        public Guid Id { get; set; } = id;
    }
}