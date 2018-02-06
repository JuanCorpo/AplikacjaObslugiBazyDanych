using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual int? Customer { get; set; }
        public int EmployeId { get; set; }
        [ForeignKey("EmployeId")]
        public virtual int? Employe { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public virtual int? Status { get; set; }
    }
}
