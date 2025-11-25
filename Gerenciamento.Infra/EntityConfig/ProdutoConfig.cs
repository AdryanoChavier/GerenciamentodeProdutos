using Gerenciamento.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerenciamento.Infra.EntityConfig;

public class ProdutoConfig : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produto");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).IsRequired();
        builder.Property(x => x.Preco).HasColumnType("decimal(18,2)").IsRequired();
        builder.Property(x => x.Quantidade).IsRequired();
    }
}