using System.ComponentModel.DataAnnotations;


namespace AplikacjaObslugiBazyDanych.Models
{
    public class Product
    {
        [Key]
        public int EmployeeId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int NumberOfBought { get; set; }
        public int StockStatus { get; set; }
        public int EmployeId { get; set; }

    }
}
