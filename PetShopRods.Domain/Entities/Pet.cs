using System;
using System.ComponentModel.DataAnnotations;
using PetShopRods.Domain.Enums;

namespace PetShopRods.Domain.Entities;

public class Pet : EntidadeBase
{
    [Required]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximo permitido 30 e minimo 3")]
    public required string Nome { get; set; }
    public Especie Especie { get; set; }
    public string? Raca { get; set; }
    public PortePet Porte { get; set; }

    [DataType(DataType.Date)]
    public DateOnly? DataNascimento { get; set; }
    public string? Observacoes { get; set; }

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
}
