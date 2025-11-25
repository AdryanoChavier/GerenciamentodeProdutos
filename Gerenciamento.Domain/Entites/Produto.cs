namespace Gerenciamento.Domain.Entites;

public class Produto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("A quantidade a remover deve ser maior que zero.");

        if (Quantidade < quantidade)
            throw new InvalidOperationException("Quantidade insuficiente em estoque.");

        Quantidade -= quantidade;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("A quantidade a adicionar deve ser maior que zero.");

        Quantidade += quantidade;
    }
}
