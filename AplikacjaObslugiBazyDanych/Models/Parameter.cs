using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    class Parameter
    {   
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual int? Product { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual int? Category { get; set; }
        public int ParameterId { get; set; }
        [ForeignKey("ParameterId")]
        public virtual int? ParameterType { get; set; }
        public string Value { get; set; }
    }
}
