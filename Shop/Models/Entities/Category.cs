﻿using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
