namespace ProjetoEstagioAPI.Models;

public class Order : BaseEntity
{
    public long ClientId { get; set; }
    public Client Client { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total {  get; set; }
    public List<ProductOrder> ProductOrders { get; set; }
    public Order()
    { }

    public Order(long clientId, DateTime orderDate, decimal total, List<ProductOrder> productOrders)
    {
        ClientId = clientId;
        OrderDate = orderDate;
        Total = total;
        ProductOrders = productOrders;
    }
}
