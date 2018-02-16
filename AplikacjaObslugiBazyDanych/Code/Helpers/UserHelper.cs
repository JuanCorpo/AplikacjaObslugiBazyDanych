using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AplikacjaObslugiBazyDanych.Code.Enums;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Code.Helpers
{
    public static class UserHelper
    {
        private static DatabaseContext context = new DatabaseContext();
        public static Employee Employee { get; set; }
        public static List<RoleClaim> Claims { get; set; }

        private static bool _LoggedIn;

        public static bool LoggedIn
        {
            get => _LoggedIn;
            set
            {
                Claims = value ? context.RolesClaims.Where(a => a.RoleId == Employee.RoleId).ToList() : new List<RoleClaim>();
                _LoggedIn = value;
            }
        }

        public static string HashPassword(string password)
        {
            return (password.GetHashCode()*2).ToString()+(password.GetHashCode()*3).ToString();
        }

        public static bool IsInClaim(Claims claim)
        {
            return Claims.Any(a => a.ClaimId == (int)claim);
        }
        //public static bool IsInClaims(param Claims[] claims) { }
        //public static bool IsInRole(int role) { }
    }
}
