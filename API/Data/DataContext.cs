using Microsoft.EntityFrameworkCore;
using DesafioChallengeSPA.Models;

namespace DesafioChallengeSPA.Data
{
    public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
    }
}