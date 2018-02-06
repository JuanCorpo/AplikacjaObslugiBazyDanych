using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    class OrderDetail
    {
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual int? Order { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual int? Product { get; set; }
        public int Amount { get; set; }
        public int Discount { get; set; }
        public int Price { get; set; }
    }
}
