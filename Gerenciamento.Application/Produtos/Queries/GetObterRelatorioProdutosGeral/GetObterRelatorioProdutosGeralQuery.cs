using Gerenciamento.Application.DTOs;
using MediatR;

namespace Gerenciamento.Application.Produtos.Queries.GetObterRelatorioProdutosGeral
{
    public class GetRelatorioGeralProdutosQuery : IRequest<IEnumerable<ProdutoRelatorioDto>>
    {
    }
}
