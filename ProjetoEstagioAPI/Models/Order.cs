namespace ProjetoEstagioAPI.Models;

public class Order : BaseEntity
{
    public long ClientId { get; set; }
    public Client Client { get; set; }
    public DateTime OrderDate { get; set; }

    public decimal Total {  get; set; }
}
