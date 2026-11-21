using System;

namespace PetShopRods.Domain.Entities;

public class Cliente : EntidadeBase
{
    public int PessoaId { get; set; }
    public Pessoa Pessoa { get; set; } = null!;
}
