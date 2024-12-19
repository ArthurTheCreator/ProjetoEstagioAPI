﻿namespace ProjetoEstagioAPI.Models;

public class ProductOrder
{
    public long ProductId { get; set; }
    public int Quantity { get; set; }

    public ProductOrder()
    {}
    public ProductOrder(long productId, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }
}