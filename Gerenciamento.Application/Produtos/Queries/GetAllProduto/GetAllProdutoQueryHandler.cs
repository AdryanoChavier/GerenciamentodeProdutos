using AutoMapper;
using Gerenciamento.Application.DTOs;
using Gerenciamento.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.Application.Produtos.Queries.GetAllProduto
{
    public class GetAllProdutoQueryHandler(
    IMapper mapper,
    IProdutoRepository produtoRepository) : IRequestHandler<GetAllProdutoQuery, IEnumerable<ProdutoDto>>
    {
        public async Task<IEnumerable<ProdutoDto>> Handle(GetAllProdutoQuery request, CancellationToken cancellationToken)
        {
            
            return mapper.Map<IEnumerable<ProdutoDto>>(await produtoRepository.GetAllAsync()); ;
        }
    }
}
