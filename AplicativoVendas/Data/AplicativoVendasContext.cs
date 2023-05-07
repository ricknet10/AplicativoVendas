using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicativoVendas.Models;
using Microsoft.Identity.Client;

namespace AplicativoVendas.Data
{
    public class AplicativoVendasContext : DbContext
    {
        public AplicativoVendasContext (DbContextOptions<AplicativoVendasContext> options)
            : base(options)
        {
             

        }

        public DbSet<Department> Department { get; set; } = default!;
    }
}
