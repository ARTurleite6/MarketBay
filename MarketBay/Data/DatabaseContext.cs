using System;
using MarketBay.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketBay.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
            
        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Morada> Moradas { get; set; }
    }
}

