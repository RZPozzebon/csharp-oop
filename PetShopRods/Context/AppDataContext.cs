using Microsoft.EntityFrameworkCore;
using PetShopRods.Domain.Entities;

namespace PetShopRods.Context;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoa { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<FormaPagamento> FormaPagamento { get; set; }
    public DbSet<Pet> Pet { get; set; }
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Servico> Servico { get; set; }
}
