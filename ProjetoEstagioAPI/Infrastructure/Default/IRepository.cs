using Microsoft.EntityFrameworkCore.Update.Internal;

namespace ProjetoEstagioAPI.Infrastructure.Default;

public interface IRepository<T> where T : class
{
    Task <List<T>> GetAll();
    Task<T> Get(long id);
    Task<T> Create(T entity);
    Task<bool> Update(T entity);
    Task<bool> Delete(long id);
}
