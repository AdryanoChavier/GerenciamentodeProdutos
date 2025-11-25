using AutoMapper;
using Gerenciamento.Domain.Repositories;
using MediatR;


namespace Gerenciamento.Application.Produtos.Commands.UpdateProduto
{
    public class UpdateProdutoCommandHandler(IMapper mapper, IProdutoRepository produtoRepository): IRequestHandler<UpdateProdutoCommand>
    {
        public async Task Handle(UpdateProdutoCommand request, CancellationToken cancellationToken)
        {
           
            var restaurant = await produtoRepository.GetByIdAsync(request.Id);

            mapper.Map(request, restaurant);

            await produtoRepository.SaveChanges();

        }
    
    }
}
