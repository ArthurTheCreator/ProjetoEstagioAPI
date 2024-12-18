﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEstagioAPI.Models
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long BrandId { get; set; }
        public long Stock { get; set; }

        public Brand? Brand { get; set; }
    }
}