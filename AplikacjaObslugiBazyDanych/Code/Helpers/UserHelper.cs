using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Code.Helpers
{
    public static class UserHelper
    {
        public static Employee Employee { get; set; }



        public static string HashPassword(string password)
        {
            return (password.GetHashCode()*2).ToString()+(password.GetHashCode()*3).ToString();
        }
    }
}
