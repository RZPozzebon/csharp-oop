namespace csharp_oop_fundamento.Domain.Models;

public class Funcionario : Pessoa
{
    public string? Periodo { get; set; }
    public required string TipoContrato { get; set; }
    public decimal Salario { get; set; }
}