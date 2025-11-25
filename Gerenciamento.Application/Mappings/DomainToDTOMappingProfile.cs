using AutoMapper;
using Gerenciamento.Domain.Entites;
using Gerenciamento.Application.DTOs;
using Gerenciamento.Application.Produtos.Commands.CreateProduto;
using Gerenciamento.Application.Produtos.Commands.UpdateProduto;

namespace Gerenciamento.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        
        CreateMap<Produto, ProdutoDto>();
        CreateMap<CreateProdutoCommand, Produto>();
        CreateMap<UpdateProdutoCommand, Produto>();
     
    }
}
