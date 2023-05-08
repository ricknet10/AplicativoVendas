using System.Collections;

namespace AplicativoVendas.Models
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department>Department { get; set; }
    }
}
