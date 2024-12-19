using Microsoft.EntityFrameworkCore;
using ProjetoEstagioAPI.Context;
using ProjetoEstagioAPI.Infrastructure.Default;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Infrastructure.Brands;

public class BrandRepository : Repository<Brand>, IBrandRepository
{
    public BrandRepository(AppDbContext context, DbSet<Brand> dbSet) : base(context, dbSet)
    {
    }
}