using System;
using PetShopRods.Domain.Enums;

namespace PetShopRods.Domain.Entities;

public class Funcionario : EntidadeBase
{
    public int PessoaId { get; set; }
    public Pessoa Pessoa { get; set; } = null!;
    public Periodo Periodo { get; set; }
    public TipoContrato TipoContrato { get; set; }
    public decimal Salario { get; set; }
}
