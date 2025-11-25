using FluentValidation;


namespace Gerenciamento.Application.Produtos.Commands.UpdateProduto
{
    public class UpdateProdutoCommandValidator : AbstractValidator<UpdateProdutoCommand>
    {
        public UpdateProdutoCommandValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("O nome do produto é obrigatório.");

            RuleFor(x => x.Preco).GreaterThanOrEqualTo(0).WithMessage("O preço não pode ser negativo.");
        }
    }
}
