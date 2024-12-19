﻿using ProjetoEstagioAPI.Arguments.Order;
using ProjetoEstagioAPI.Models;

namespace ProjetoEstagioAPI.Mapping.Orders
{
    public static class OrderConverter
    {
        public static OutputOrder? ToOutputOrder(Order? order)
        {
            if (order is null) return null;
            return new OutputOrder(order.ClientId, order.ProductOrders, order.Total, order.OrderDate);
        }
        public static List<OutputOrder?> ToOutputOrder(List<Order?> order)
        {
            if (order is null) return null;
            return order.Select(o => new OutputOrder(o.ClientId, o.ProductOrders, o.Total, o.OrderDate)).ToList();
        }
        public static Order? ToOrder(InputCreateOrder order)
        {
            if (order is null) return null;
            return new Order(order.ClientId,order.OrderDate,order.ProductOrders);
        }
    }
}