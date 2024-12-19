using Microsoft.EntityFrameworkCore;
using ProjetoEstagioAPI.Context;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Infrastructure.Default
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext context, DbSet<TEntity> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public List<TEntity> GetAll()
        {
            return  _dbSet.ToList();
        }
        public async Task<TEntity?> Get(long id)
        {
            return await _dbSet.FindAsync(id);
        }
        public  async Task<bool> Update(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }
        public async Task<bool> Delete(long id)
        {
            var entityRemove = await _dbSet.FindAsync(id);
            _dbSet.Remove(entityRemove);
            return true;
        }
        public async void SaveChances()
        {
            await _context.SaveChangesAsync();
        }
    }
}