using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class Parameter
    {   
        [Key]
        public int ParameterId { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int ParameterTypeId { get; set; }
        [ForeignKey("ParameterTypeId")]
        public virtual ParameterType ParameterType { get; set; }

        public string Value { get; set; }
    }
}
