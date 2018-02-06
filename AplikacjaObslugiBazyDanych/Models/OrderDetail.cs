using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public int Amount { get; set; }

        public int Discount { get; set; }

        public int Price { get; set; }
    }
}
