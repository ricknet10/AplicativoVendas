using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicativoVendas.Models;
using Microsoft.Identity.Client;

namespace AplicativoVendas.Models
{
    public class AplicativoVendasContext : DbContext
    {
        public AplicativoVendasContext (DbContextOptions<AplicativoVendasContext> options)
            : base(options)
        {
             

        }

        public DbSet<Department> Department { get; set; } 
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
