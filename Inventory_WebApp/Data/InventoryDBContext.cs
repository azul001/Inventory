using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory_WebApp.Models;

namespace Inventory_WebApp.Data
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext (DbContextOptions<InventoryDBContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory_WebApp.Models.Product> Product { get; set; } = default!;
    }
}
