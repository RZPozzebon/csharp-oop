

using System.ComponentModel.DataAnnotations;
using PetShopRods.Domain.Enums;

namespace PetShopRods.Domain.Entities;

public class Pessoa : EntidadeBase
{
    [Required]
    public string Nome { get; set; } = string.Empty;
    [Required]
    public string Cpf { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateOnly DataNascimento { get; set; }
    public Sexo? Sexo { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Endereco { get; set; }

    public Cliente? Cliente { get; set; }
    public Funcionario? Funcionario { get; set; }

    public int Idade => CalcularIdade(DateOnly.FromDateTime(DateTime.Today));

    public int CalcularIdade(DateOnly referencia)
    {
        var idade = referencia.Year - DataNascimento.Year;
        if (DataNascimento > referencia.AddYears(-idade)) idade--;
        return idade;
    }
}
