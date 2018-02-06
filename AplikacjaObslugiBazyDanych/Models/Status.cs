using System.ComponentModel.DataAnnotations;

namespace AplikacjaObslugiBazyDanych.Models
{
    class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
