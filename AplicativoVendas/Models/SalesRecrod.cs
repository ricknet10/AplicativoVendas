using Nest;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicativoVendas.Models
{

    [Table("SalesRecrod")]
    public class SalesRecrod
    {

        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Data")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        [Column("Amount")]
        [Display(Name = "Amount")]
        public double Amount { get; set; }
        [Column("Status")]
        [Display(Name = "Status")]
        public SaleStatus Status { get; set; }
        [Column("Seller")]
        [Display(Name = "Seller")]
        public Seller Seller { get; set; }

        public SalesRecrod (int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
