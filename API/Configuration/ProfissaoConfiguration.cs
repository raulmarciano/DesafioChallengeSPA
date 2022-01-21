using DesafioChallengeSPA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Configuration
{
    public class ProfissaoConfiguration : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.HasData(
                new Profissao { Id = 1, Nome = "Programador" },
                new Profissao { Id = 2, Nome = "Analista" },
                new Profissao { Id = 3, Nome = "Scrum Master" },
                new Profissao { Id = 4, Nome = "DevOps" }
            );
        }
    }
}