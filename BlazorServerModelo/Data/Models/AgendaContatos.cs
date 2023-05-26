using System.ComponentModel.DataAnnotations;

namespace BlazorServerModelo.Data
{
    public class AgendaContatos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório")]
        [MaxLength(60, ErrorMessage = "No máximo 60 digitos")]
        [MinLength(4, ErrorMessage = "No mínimo 4 digitos")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório")]
        [MaxLength(60, ErrorMessage = "No máximo 60 digitos")]
        [MinLength(4, ErrorMessage = "No mínimo 4 digitos")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [MaxLength(60, ErrorMessage = "No máximo 60 digitos")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        public string? Telefone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Nascimento { get; set; }

    }
}
