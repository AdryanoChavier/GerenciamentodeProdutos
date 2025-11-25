using AutoMapper;
using Gerenciamento.Domain.Repositories;
using MediatR;


namespace Gerenciamento.Application.Produtos.Commands.AdicionarProduto
{
    public class AdicionarProdutoCommandHandler(IProdutoRepository produtoRepository) : IRequestHandler<AdicionarProdutoCommand>
    {
        public async Task Handle(AdicionarProdutoCommand request, CancellationToken cancellationToken)
        {
            var produto = await produtoRepository.GetByIdAsync(request.ProdutoId);

            if (produto == null)
                throw new Exception("Produto não encontrado.");

            produto.AdicionarEstoque(request.QuantidadeEntrada);

            await produtoRepository.SaveChanges();

            return;
        }
    }
}