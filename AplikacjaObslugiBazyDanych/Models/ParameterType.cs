using System.ComponentModel.DataAnnotations;

namespace AplikacjaObslugiBazyDanych.Models
{
    class ParameterType
    {
        [Key]
        public int ParameterId { get; set; }
        public string ParameterName { get; set; }
        public string ValueType { get; set; }
    }
}
