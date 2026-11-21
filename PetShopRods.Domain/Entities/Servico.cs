using System;
using System.ComponentModel.DataAnnotations;

namespace PetShopRods.Domain.Entities;

public class Servico : EntidadeBase
{
    public required string Nome { get; set; }
    public decimal Valor { get; set; }
    [DataType(DataType.Time)]
    public DateOnly? TempoServico { get; set; }
    public int IdFormaPagamento { get; set; }
    public FormaPagamento FormaPagameto { get; set; } = null!;
}
