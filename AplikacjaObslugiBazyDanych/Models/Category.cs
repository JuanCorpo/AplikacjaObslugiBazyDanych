using System.ComponentModel.DataAnnotations;

namespace AplikacjaObslugiBazyDanych.Models
{
    class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
