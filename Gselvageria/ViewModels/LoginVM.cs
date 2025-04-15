using System.ComponentModel.DataAnnotations;
namespace Gselvageria.ViewModels;

public class LoginVM
{
    [Display(Name ="Email ou Nome de Usuário", Prompt = "Informe seu Email ou nome de usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "*********")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    [DataType(DataType.Password)]

    public string Senha { get; set; }

    [Display(Name = "Manter Conectado")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
}