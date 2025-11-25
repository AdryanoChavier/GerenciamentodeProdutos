using AutoMapper;
using Gerenciamento.Domain.Repositories;
using MediatR;

namespace Gerenciamento.Application.Produtos.Commands.SaidaProduto
{
    public class SaidaProdutoCommanHandler(IMapper mapper, IProdutoRepository produtoRepository) : IRequestHandler<SaidaProdutoCommand>
    {
        public async Task Handle(SaidaProdutoCommand request, CancellationToken cancellationToken)
        {
            var produto = await produtoRepository.GetByIdAsync(request.ProdutoId);

            if (produto == null)
                throw new Exception("Produto não encontrado.");

            if (request.QuantidadeSaida <= 0)
                throw new Exception("Quantidade de saída deve ser maior que zero.");

            if (produto.Quantidade < request.QuantidadeSaida)
                throw new Exception("Quantidade insuficiente em estoque.");

            // Atualizar o estoque do produto
            produto.RemoverEstoque(request.QuantidadeSaida);

            await produtoRepository.SaveChanges();

            return;
        }

    }
}