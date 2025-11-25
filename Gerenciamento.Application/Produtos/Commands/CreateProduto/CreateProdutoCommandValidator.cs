using FluentValidation;

namespace Gerenciamento.Application.Produtos.Commands.CreateProduto;

public class CreateProdutoCommandValidator : AbstractValidator<CreateProdutoCommand>
{
    public CreateProdutoCommandValidator()
    {
        RuleFor(x => x.Nome).NotEmpty().WithMessage("O nome do produto é obrigatório.");
            
        RuleFor(x => x.Preco).GreaterThanOrEqualTo(0).WithMessage("O preço não pode ser negativo.");

        RuleFor(x => x.Quantidade).GreaterThan(0).WithMessage("A quantidade inicial deve ser maior que zero.");
    }
}
