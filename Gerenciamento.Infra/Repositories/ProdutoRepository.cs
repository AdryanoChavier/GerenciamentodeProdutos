using Gerenciamento.Infra.Persistence;
using Gerenciamento.Domain.Entites;
using Gerenciamento.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Gerenciamento.Infra.Repositories;

public class ProdutoRepository (ProdutoDbContext dbContext) : IProdutoRepository
{
    public async Task Create(Produto entity)
    {
        dbContext.Produto.Add(entity);
        await dbContext.SaveChangesAsync();
        
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        var produtos = await dbContext.Produto.ToListAsync();
        return produtos;
    }
    public async Task<Produto?> GetByIdAsync(Guid id)
    {
        var produto = await dbContext.Produto.FirstOrDefaultAsync(x => x.Id == id);
        return produto;
    }

    public async Task Delete(Produto entity)
    {
        dbContext.Remove(entity);
        await dbContext.SaveChangesAsync();
    }

    public Task SaveChanges()
    => dbContext.SaveChangesAsync();
}


