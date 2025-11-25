
using AutoMapper;
using Gerenciamento.Application.DTOs;
using Gerenciamento.Domain.Repositories;
using MediatR;

namespace Gerenciamento.Application.Produtos.Queries.GetObterRelatorioProdutosGeral
{
    public class GetObterRelatorioProdutosGeralQueryHandler(IProdutoRepository produtoRepository, IMapper mapper) : IRequestHandler<GetRelatorioGeralProdutosQuery, IEnumerable<ProdutoRelatorioDto>>
    {
        public async Task<IEnumerable<ProdutoRelatorioDto>> Handle(GetRelatorioGeralProdutosQuery request, CancellationToken cancellationToken)
        {
            var produtos = await produtoRepository.GetAllAsync();

            var relatorio = produtos.Select(p => new ProdutoRelatorioDto
            {
                Id = p.Id,
                Nome = p.Nome,
                QuantidadeAtual = p.Quantidade,
                SemEstoque = p.Quantidade == 0
            });

            return relatorio;
        }
    }
}
