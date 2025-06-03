using System.ComponentModel.DataAnnotations;

namespace Gselvageria.ViewModels;

public class RegistroVM
{
    [Display(Name = "Nome Completo", Prompt = "Informe seu nome completo")]
    [Required(ErrorMessage = "Por favor, informe seu nome completo")]
    [StringLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento", Prompt = "Informe sua data de nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
    public DateTime? DataNascimento { get; set; } = null;

    [Display(Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [EmailAddress(ErrorMessage = "O Email informado não é válido")]
    [StringLength(100, ErrorMessage = "O Email deve ter no máximo 100 caracteres")]        
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha", Prompt = "Informe uma senha para acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirmação de Senha", Prompt = "Confirme sua senha")]
    [Compare("Senha", ErrorMessage = "As senhas não conferem")]
    public string ConfirmacaoSenha { get; set; }

    public IFormFile Foto { get; set; }
}
