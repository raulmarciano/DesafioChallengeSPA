using Microsoft.EntityFrameworkCore;
using DesafioChallengeSPA.Models;
using API.Configuration;

namespace DesafioChallengeSPA.Data
{
    public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProfissaoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }
    }
}