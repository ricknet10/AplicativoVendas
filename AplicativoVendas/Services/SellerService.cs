using AplicativoVendas.Models;

namespace AplicativoVendas.Services
{
    public class SellerService
    {
        private readonly AplicativoVendasContext _context;

        public SellerService(AplicativoVendasContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();

        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
