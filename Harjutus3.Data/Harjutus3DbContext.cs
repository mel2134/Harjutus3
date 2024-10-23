using Harjutus3.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus3.Data
{
    public class Harjutus3DbContext : DbContext
    {
        public Harjutus3DbContext(DbContextOptions<Harjutus3DbContext> options): base(options) { }

        public DbSet<Workers> Workers { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<SellHistory> SellHistory { get; set; }
        public DbSet<BuyHistory> BuyHistory { get; set; }
    }
}
