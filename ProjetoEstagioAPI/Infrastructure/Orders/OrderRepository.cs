using Microsoft.EntityFrameworkCore;
using ProjetoEstagioAPI.Context;
using ProjetoEstagioAPI.Infrastructure.Default;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Infrastructure.Orders
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context, DbSet<Order> dbSet) : base(context, dbSet)
        {
        }
    }
}
