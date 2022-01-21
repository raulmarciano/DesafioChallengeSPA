using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioChallengeSPA.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30, ErrorMessage = "Este campo deve conter entre 3 e 30 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 30 caracteres")]
        [DataType("NVARCHAR(30)")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 100 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 100 caracteres")]
        [DataType("NVARCHAR(100)")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(11, ErrorMessage = "Este campo deve conter 11 caracteres")]
        [MinLength(11, ErrorMessage = "Este campo deve conter 11 caracteres")]
        [DataType("NVARCHAR(11)")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "DATE")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int ProfissaoId { get; set; }

        public Profissao Profissao { get; set; }
    }
}