using Gerenciamento.Domain.Entites;

namespace Gerenciamento.Domain.Repositories;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetAllAsync();
    Task<Produto?> GetByIdAsync(Guid id);
    Task Create(Produto entity);
    Task Delete(Produto entity);
    Task SaveChanges();
}