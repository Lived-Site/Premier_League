using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context;

public class PremierLeagueContext : DbContext
{
    public PremierLeagueContext(DbContextOptions<PremierLeagueContext> options)
        : base(options)
    {
    }

    public DbSet<Equipo> Equipos => Set<Equipo>();
    public DbSet<Partido> Partidos => Set<Partido>();
    public DbSet<Fecha> Fechas => Set<Fecha>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(PremierLeagueContext).Assembly);
    }
}