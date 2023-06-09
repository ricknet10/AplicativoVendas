﻿using Nest;
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
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Column("BirthDate")]
        [Display(Name = "Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime BirthDate { get; set; }
        [Column("BaseSalary")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        
        public double BaseSalary { get; set; }
        [Column("Department")]
        [Display(Name = "Departmento")]

        public Department Department { get; set; }
        public int DepartmentId { get;set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial,DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }



    }

}
