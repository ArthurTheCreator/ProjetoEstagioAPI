using Microsoft.EntityFrameworkCore;
using ProjetoEstagioAPI.Context;
using ProjetoEstagioAPI.Infrastructure.Brands;
using ProjetoEstagioAPI.Infrastructure.Clients;
using ProjetoEstagioAPI.Infrastructure.Orders;
using ProjetoEstagioAPI.Infrastructure.Products;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IBrandRepository _brandRepository;
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;
        private IClientRepository _clientRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IBrandRepository BrandRepository
        {
            get
            {
                return _brandRepository ??= new BrandRepository(_context, _context.Set<Brand>());
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository ??= new ProductRepository(_context, _context.Set<Product>());
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository ??= new OrderRepository(_context, _context.Set<Order>());
            }
        }

        public IClientRepository ClientRepository
        {
            get
            {
                return _clientRepository ??= new ClientRepository(_context, _context.Set<Client>());
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}