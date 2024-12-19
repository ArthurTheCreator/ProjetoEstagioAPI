using ProjetoEstagioAPI.Infrastructure.Products;
using ProjetoEstagioAPI.Models;
using System.Text.Json.Serialization;

namespace ProjetoEstagioAPI.Mapping.Orders
{
    public class OutputOrder
    {
        protected readonly ProductRepository _repository;

        public OutputOrder(ProductRepository repository)
        {
            _repository = repository;
        }

        public long ClientId { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total
        {
            get
            {
                return Total;
            }
            set
            {
                var products = _repository.GetAll();
                var ids = ProductOrders.Select(p => p.ProductId).ToList();
                var quantitys = ProductOrders.Select(p => p.Quantity).ToList();
                Total = products
                    .Where(product => ids.Contains(product.Id)) // Filtra os produtos com IDs correspondentes
                    .Select(product =>
                        product.Price * ProductOrders.First(order => order.ProductId == product.Id).Quantity
                    )
                    .Sum();
            }
        }
        [JsonConstructor]
        public OutputOrder(long clientId, List<ProductOrder> productOrders, DateTime orderDate)
        {
            ClientId = clientId;
            ProductOrders = productOrders;
            OrderDate = orderDate;
        }
    }
}