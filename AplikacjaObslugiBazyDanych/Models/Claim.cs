using System.ComponentModel.DataAnnotations;
using AplikacjaObslugiBazyDanych.Code.Enums;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }

        public string ClaimName { get; set; }
    }
}
