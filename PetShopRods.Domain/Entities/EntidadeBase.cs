using System.ComponentModel.DataAnnotations;

namespace PetShopRods.Domain.Entities;

public class EntidadeBase
{
    [Key]
    public int Id { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime CriadoEm { get; set; }
    public DateTime? AtualizadoEm { get; set; }
}
