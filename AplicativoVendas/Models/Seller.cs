using Nest;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace AplicativoVendas.Models
{
    [Table("Seller")]

    public class Seller
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Column("BirthDate")]
        [Display(Name = "BirthDate")]
        public string BirthDate { get; set; }
        [Column("BaseSalary")]
        [Display(Name = "BaseSalary")]
        public double BaseSalary { get; set; }
        [Column("Department")]
        [Display(Name = "Department")]

        public Department Department { get; set; }
        public ICollection<SalesRecrod> Sales { get; set; } = new List<SalesRecrod>();

        
        public Seller(int id, string name, string email, string birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecrod sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecrod sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial,DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }



    }

}
