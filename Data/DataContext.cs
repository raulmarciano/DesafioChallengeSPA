using Microsoft.EntityFrameworkCore;
using DesafioChallengeSPA.Model;

namespace DesafioChallengeSPA.Data
{
    public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}