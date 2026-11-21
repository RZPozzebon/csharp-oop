using System;

namespace PetShopRods.Domain.Entities;

public class FormaPagamento : EntidadeBase
{
    public string Nome { get; private set; } = string.Empty;

}
