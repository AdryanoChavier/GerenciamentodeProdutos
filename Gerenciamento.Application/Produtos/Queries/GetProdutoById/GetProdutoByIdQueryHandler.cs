using AutoMapper;
using Gerenciamento.Application.DTOs;
using Gerenciamento.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.Application.Produtos.Queries.GetProdutoById
{
    internal class GetProdutoByIdQueryHandler(IMapper mapper, IProdutoRepository produtoRepository) : IRequestHandler<GetProdutoByIdQuery, ProdutoDto>
    {
        public async Task<ProdutoDto> Handle(GetProdutoByIdQuery request, CancellationToken cancellationToken)
        {
            var produto = await produtoRepository.GetByIdAsync(request.Id);
            var produtoDto = mapper.Map<ProdutoDto>(produto);
            return produtoDto;
        }
    }
}
