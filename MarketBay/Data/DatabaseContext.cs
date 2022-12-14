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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<StandFeirante>()
                .HasOne<Feirante>(f => f.Feirante)
                .WithMany(f => f.Stands)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Compra>()
                .HasOne<StandFeirante>(s => s.StandFeirante)
                .WithMany(s => s.Vendas)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<ClassificacoesCliente>()
                .HasOne<Feirante>(c => c.Feirante)
                .WithMany(f => f.ClassificacoesClientes)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Proposta>()
                .HasOne<StandFeirante>(s => s.StandFeirante)
                .WithMany(s => s.Propostas)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Cliente>()
                .HasMany<Categoria>(cliente => cliente.Categorias)
                .WithMany();

            modelBuilder.Entity<FavFeirasCliente>()
                .HasOne<Cliente>()
                .WithMany(c => c.FeirasFavoritas);
            
            modelBuilder.Entity<FavFeirasCliente>()
                .HasOne<Feira>()
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Conta>()
                .HasOne<Morada>(conta => conta.Morada)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Conta>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<Feirante>()
                .HasIndex(f => f.NIFempresarial)
                .IsUnique();
                
            modelBuilder.Entity<ProdutoStand>()
                .HasOne<StandFeirante>()
                .WithMany(stand => stand.ProdutosStands)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<ProdutoStand>()
                .HasOne<Produto>()
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Feirante> Feirantes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Feira> Feiras { get; set; }
        public DbSet<StandFeirante> Stands { get; set; }
        public DbSet<CompraProduto> ComprasProdutos{ get; set; }
        public DbSet<Proposta> Propostas { get; set; }
    }
}

