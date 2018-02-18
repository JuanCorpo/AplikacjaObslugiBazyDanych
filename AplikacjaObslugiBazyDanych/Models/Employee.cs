using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AplikacjaObslugiBazyDanych.Resources;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "Login")]
        public string UserName { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "Password")]
        public string Password { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "LastName")]
        public string LastName { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "Email")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(EmployeesRes), Name = "Role")]
        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
