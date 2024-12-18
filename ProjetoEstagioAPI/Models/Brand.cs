using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEstagioAPI.Models
{
    [Table("Brand")]
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public List<Product>? Products { get; set; }
    }
}
