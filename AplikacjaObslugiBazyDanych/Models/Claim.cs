using System.ComponentModel.DataAnnotations;

namespace AplikacjaObslugiBazyDanych.Models
{
    class Claim
    {
        [Key]
        public int ClaimId { get; set; }
        public string ClaimName { get; set; }
    }
}
