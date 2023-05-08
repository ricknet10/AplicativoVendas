using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicativoVendas.Models;

namespace AplicativoVendas.Data
{
    public class SeedingService
    {
        private AplicativoVendasContext _context;

        public SeedingService(AplicativoVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            
            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com",new DateTime(1998, 4, 21), 1000.0, d1);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s1);


            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1);

            _context.SalesRecord.AddRange(
                r1, r2, r3
            );

            _context.SaveChanges();
        }
    }
}