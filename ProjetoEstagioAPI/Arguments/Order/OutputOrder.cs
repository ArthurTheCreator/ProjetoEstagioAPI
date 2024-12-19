﻿using ProjetoEstagioAPI.Infrastructure.Products;
using ProjetoEstagioAPI.Models;
using System.Text.Json.Serialization;

namespace ProjetoEstagioAPI.Arguments.Order
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
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        [JsonConstructor]
        public OutputOrder(long clientId, List<ProductOrder> productOrders, decimal total, DateTime orderDate)
        {
            ClientId = clientId;
            ProductOrders = productOrders;
            Total = total;
            OrderDate = orderDate;
        }
    }
}