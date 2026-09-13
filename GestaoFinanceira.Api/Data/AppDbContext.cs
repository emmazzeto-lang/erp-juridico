using Microsoft.EntityFrameworkCore;
using GestaoFinanceira.Api.Models;

namespace GestaoFinanceira.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Parceria> Parcerias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Definição de precisão para valores financeiros para evitar arredondamentos indevidos
            modelBuilder.Entity<Parceria>()
                .Property(p => p.ValorTotal)
                .HasPrecision(18, 2);
        }
    }
}