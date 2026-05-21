using Microsoft.EntityFrameworkCore;

namespace API_VSCode.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

    public DbSet<Produto> Produtos => Set<Produto>();
}