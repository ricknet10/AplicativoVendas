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

            Department d1 = new Department(10, "Computers");
            Department d2 = new Department(12, "Electronics");
            Department d3 = new Department(13, "Fashion");
            Department d4 = new Department(14, "Books");

            
            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com","1998, 4, 21", 1000.0, d1);
           // Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com",  DateTime(1979, 12, 31), 3500.0, d2);
           /* Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2); */

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