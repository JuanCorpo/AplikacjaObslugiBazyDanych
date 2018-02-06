using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    class RoleClaim
    {
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual int? Role { get; set; }
        public int ClaimId { get; set; }
        [ForeignKey("ClaimId")]
        public virtual int? Claim { get; set; }
    }
}
