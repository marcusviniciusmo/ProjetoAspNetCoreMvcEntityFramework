using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSalesWebMvc.Models;

namespace ProjetoSalesWebMvc.Data
{
    public class ProjetoSalesWebMvcContext : DbContext
    {
        public ProjetoSalesWebMvcContext (DbContextOptions<ProjetoSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
