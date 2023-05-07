using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
