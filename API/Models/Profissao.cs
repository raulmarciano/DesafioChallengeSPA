using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioChallengeSPA.Models
{
    [Table("Profissao")]
    public class Profissao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60, ErrorMessage = "Este campo deve conter 11 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter 11 caracteres")]
        public string Nome { get; set; }
    }
}