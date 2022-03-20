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

    }
}
