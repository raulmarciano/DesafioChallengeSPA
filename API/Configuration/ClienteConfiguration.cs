using System;
using DesafioChallengeSPA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                new Cliente { Id = 1, Nome = "Raul", Sobrenome = "Marciano", CPF = "52665483041", DataNascimento = DateTime.Parse("11/02/1997"), Idade = 24, ProfissaoId = 1 },
                new Cliente { Id = 2, Nome = "José Antonio", Sobrenome = "Oliveira", CPF = "99257878074", DataNascimento = DateTime.Parse("11/02/1995"), Idade = 26, ProfissaoId = 2 },
                new Cliente { Id = 3, Nome = "Maria", Sobrenome = "Aparecida", CPF = "42257300009", DataNascimento = DateTime.Parse("11/02/1998"), Idade = 23, ProfissaoId = 3 },
                new Cliente { Id = 4, Nome = "Isabela Genes", Sobrenome = "Dutra", CPF = "29671743005", DataNascimento = DateTime.Parse("11/02/1996"), Idade = 25, ProfissaoId = 4 }
            );
        }
    }
}