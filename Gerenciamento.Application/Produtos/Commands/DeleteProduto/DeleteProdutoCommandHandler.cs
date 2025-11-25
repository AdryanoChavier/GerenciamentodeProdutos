using Gerenciamento.Domain.Repositories;
using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.DeleteProduto
{
    public class DeleteProdutoCommandHandler(
     IProdutoRepository produtoRepository) : IRequestHandler<DeleteProdutoCommand>
    {
        public async Task Handle(DeleteProdutoCommand command, CancellationToken cancellationToken)
        {
            var restaurant = await produtoRepository.GetByIdAsync(command.Id);
            await produtoRepository.Delete(restaurant);
        }
    }
}
