using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Gselvageria.Models;

public class Usuario : IdentityUser
{
    [Required(ErrorMessage ="por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Data de Nascimento")]
    [DataType(DataType.Date)]
    public DateTime? DataNascimento { get; set; }

    [StringLength(200)]
    public string Foto  { get; set; }
}
