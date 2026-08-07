using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
namespace Repository.Configurations;

public class EquipoConfiguration
{
    public void Configure(EntityTypeBuilder<Equipo> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Ciudad)
            .HasMaxLength(100);

        builder.Property(e => e.Descripcion)
            .HasMaxLength(5000);

        builder.Property(e => e.FechaFundacion)
            .IsRequired();
        
        builder.Property(e => e.Escudo)
            .HasMaxLength(200);
        
        
    }
}