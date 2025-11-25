using Gerenciamento.Application.DTOs;
using MediatR;

namespace Gerenciamento.Application.Produtos.Queries.GetProdutoById;

public class GetProdutoByIdQuery(Guid id) : IRequest<ProdutoDto>
{
    public Guid Id { get; set; } = id;
}
