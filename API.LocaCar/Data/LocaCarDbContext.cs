using API.LocaCar.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.LocaCar.Data
{
    public class LocaCarDbContext : DbContext
    {
        public LocaCarDbContext(DbContextOptions<LocaCarDbContext> options) : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .HasOne(c => c.Agencia)
                .WithMany(a => a.Carros)
                .HasForeignKey(c => c.AgenciaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Endereco>()
                .HasOne(end => end.Agencia)
                .WithOne(ag => ag.Endereco)
                .HasForeignKey<Agencia>(ag => ag.EnderecoId);
        }
    }
}
