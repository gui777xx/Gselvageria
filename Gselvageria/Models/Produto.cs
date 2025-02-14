using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gselvageria.Models;

[Table("produto")]
public class Produto
{   
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "por favor, informe a categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]

    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(1000, ErrorMessage = "Por favore, informe a Descrição")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Por favor, informe a quantidade em estoque")]
    public int qtdeEstoque { get; set; } = 0;

    [Required(ErrorMessage = "por favor, informe o valor de custo")]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorCusto  { get; set; }

    [Required(ErrorMessage = "por favor, informe o valor de custo")]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorVenda  { get; set; }
}   
