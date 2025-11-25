using AutoMapper;
using Gerenciamento.Application.DTOs;
using Gerenciamento.Domain.Repositories;
using MediatR;

namespace Gerenciamento.Application.Produtos.Queries.GetProdutoBaixoEstoque
{
    public class GetProdutoBaixoEstoqueHandler(IMapper mapper, IProdutoRepository produtoRepository) : IRequestHandler<GetProdutoBaixoEstoqueQuery, IEnumerable<ProdutoDto>>
    {
        public async Task<IEnumerable<ProdutoDto>> Handle(GetProdutoBaixoEstoqueQuery request, CancellationToken cancellationToken)
        {
            var produtos = await produtoRepository.GetAllAsync();
            var produtosBaixoEstoque = produtos.Where(p => p.Quantidade < 5);

            return mapper.Map<IEnumerable<ProdutoDto>>(produtosBaixoEstoque);
        }
    }
}
