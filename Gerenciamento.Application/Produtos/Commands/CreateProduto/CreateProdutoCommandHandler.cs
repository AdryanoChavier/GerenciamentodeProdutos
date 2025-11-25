using AutoMapper;
using Gerenciamento.Domain.Entites;
using Gerenciamento.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Gerenciamento.Application.Produtos.Commands.CreateProduto;

public class CreateProdutoCommandHandler(ILogger<CreateProdutoCommandHandler> logger, IMapper mapper,
    IProdutoRepository produtoRepository) : IRequestHandler<CreateProdutoCommand>
{
    public async Task Handle(CreateProdutoCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("O Produto {@produto}", request);

        var produto = mapper.Map<Produto>(request);

        await produtoRepository.Create(produto);
    }
}
