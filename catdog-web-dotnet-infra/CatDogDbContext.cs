using catdog_web_dotnet_domain.Entities;
using CatdogWeb.Domain;
using Microsoft.EntityFrameworkCore;

namespace CatdogWeb
{
    public class CatDogDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoProduto> TipoProduto { get; set; }
        public DbSet<TipoCargo> TipoCargo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=GLAUBER-MENDES\\SQLEXPRESS;Database=Catdogweb;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<>()
            //.ToTable("")
            //.Property(x => x.PlanoContaId)
            //.HasColumnName("");
        }
    }
}
