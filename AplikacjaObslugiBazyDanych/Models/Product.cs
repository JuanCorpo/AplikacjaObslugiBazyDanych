using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual int? Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int NumberOfBought { get; set; }
        public int StockStatus { get; set; }      
        public int EmployeId { get; set; }
        [ForeignKey("EmployeId")]
        public virtual int? Employe { get; set; }
    }
}
