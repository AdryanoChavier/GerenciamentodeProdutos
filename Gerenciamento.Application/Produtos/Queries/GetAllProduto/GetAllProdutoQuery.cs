using Gerenciamento.Application.DTOs;
using MediatR;

namespace Gerenciamento.Application.Produtos.Queries.GetAllProduto;

public class GetAllProdutoQuery : IRequest<IEnumerable<ProdutoDto>>
{

}
