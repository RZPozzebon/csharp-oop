namespace csharp_oop_fundamento.Domain.Models;

public class Pet
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Raca { get; set; }
    public required string Sexo { get; set; }
    public int Idade { get; set; }
}