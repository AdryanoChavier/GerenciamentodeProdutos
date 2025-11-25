namespace Gerenciamento.Application.DTOs
{
    public class ProdutoRelatorioDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAtual { get; set; }
        public bool SemEstoque { get; set; }
    }
}
