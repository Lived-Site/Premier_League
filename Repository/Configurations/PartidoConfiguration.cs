using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configurations;

public class PartidoConfiguration : IEntityTypeConfiguration<Partido>
{
    public void Configure(EntityTypeBuilder<Partido> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.EquipoLocal)
            .WithMany()
            .HasForeignKey(p => p.EquipoLocalId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.EquipoVisitante)
            .WithMany()
            .HasForeignKey(p => p.EquipoVisitanteId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Fecha)
            .WithMany(f => f.Partidos)
            .HasForeignKey(p => p.FechaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
