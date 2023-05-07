using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AplicativoVendas.Models
{

    [Table("Department")]
    public class Department
    {

        [Column("Id")]
        [Display(Name = "CODIGO")]  

        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();  
           
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));    
        }
    }
}
