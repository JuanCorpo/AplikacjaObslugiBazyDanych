using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AplikacjaObslugiBazyDanych.Code.Enums;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class RoleClaim
    {
        [Key]
        [Column(Order = 0)]
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ClaimId { get; set; }
        [ForeignKey("ClaimId")]
        public virtual Claim Claim { get; set; }
    }
}
