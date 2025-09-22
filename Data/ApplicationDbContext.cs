using Microsoft.EntityFrameworkCore;
using BlContainerSystem.Models;

namespace BlContainerSystem.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Estas propriedades dizem ao Entity Framework quais classes
    // devem se tornar tabelas no banco de dados.
    public DbSet<BL> BLs { get; set; }
    public DbSet<Container> Containers { get; set; }
}