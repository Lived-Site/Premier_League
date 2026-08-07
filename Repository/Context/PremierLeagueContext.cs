using Microsoft.EntityFrameworkCore;
using Domain;
namespace Repository.Context;

public class PremierLeagueContext : DbContext
{
    public PremierLeagueContext(DbContextOptions<PremierLeagueContext> options) : base(options)
    {
    }

    public DbSet<Equipo> Equipos => Set<Equipo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PremierLeagueContext).Assembly);
    }
}