using System.ComponentModel.DataAnnotations;
using AplikacjaObslugiBazyDanych.Resources;

namespace AplikacjaObslugiBazyDanych.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        /*
         [Display(ResourceType = typeof (Global), Name = "Surname")] // do zasobów
         [Required(ErrorMessageResourceType = typeof (Global), ErrorMessageResourceName = "RequiredField")]
         [MinLength(2, ErrorMessageResourceType = typeof (EmployeesRes), ErrorMessageResourceName = "Enter2Letters")]
         [RegularExpression(@"^((\d{10})|(\d{3}\-\d{3}\-\d{2}\-\d{2})|(\d{3}\-\d{2}\-\d{2}\-\d{3}))$", ErrorMessage = "Niepoprawny NIP")]
         */

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
        public int RoleId { get; set; }

        /*
        public virtual int? ProviderId { get; set; }
        [ForeignKey("ProviderId")]
        [Display(ResourceType = typeof(ItemsRes), Name = "Provider")]
        public virtual Customer Provider { get; set; }   
        */

        // virtual ICollecition<> Role
       
    }
}
