﻿using AplicativoVendas.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AplicativoVendas.Models;

namespace AplicativoVendas.Services
{
    public class DepartmentService
    {
        private readonly AplicativoVendasContext _context;

        public DepartmentService(AplicativoVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}