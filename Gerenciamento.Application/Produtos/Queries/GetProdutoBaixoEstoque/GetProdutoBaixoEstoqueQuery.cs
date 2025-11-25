using Gerenciamento.Application.DTOs;
using MediatR;

namespace Gerenciamento.Application.Produtos.Queries.GetProdutoBaixoEstoque
{
    public class GetProdutoBaixoEstoqueQuery : IRequest<IEnumerable<ProdutoDto>>
    {

    }
}
