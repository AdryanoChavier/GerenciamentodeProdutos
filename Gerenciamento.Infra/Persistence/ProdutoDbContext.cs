using Gerenciamento.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Gerenciamento.Infra.EntityConfig;

namespace Gerenciamento.Infra.Persistence;

public class ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : DbContext(options)
{
    public DbSet<Produto> Produto { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ProdutoConfig());
    }
}