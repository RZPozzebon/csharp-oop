using System.ComponentModel.DataAnnotations;

namespace PetShopRods.Domain.Entities;

public class Produto : EntidadeBase
{
    [Required]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximo permitido 30 e minimo 3")]
    public string Nome { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public int IdFormaPagamento { get; set; }
    public FormaPagamento FormaPagameto { get; set; } = null!;
}
