namespace Domain;

public class Fecha
{
    public int Id { get; set; }
    public int NumeroDeFecha { get; set; }
    public List<Partido> Partidos { get; set; } = new List<Partido>(); 
    
    public Fecha(){}

    public Fecha(int numeroDeFecha)
    {
        NumeroDeFecha = numeroDeFecha;
    }

    public void AgregarPartido(Partido partido)
    {
        if (Partidos.Count >= 10)
        {
            throw new InvalidOperationException(
                "Una fecha no puede tener más de 10 partidos.");
        }

        if (Partidos.Any(p =>
                p.EquipoLocal.Id == partido.EquipoLocal.Id ||
                p.EquipoVisitante.Id == partido.EquipoLocal.Id ||
                p.EquipoLocal.Id == partido.EquipoVisitante.Id ||
                p.EquipoVisitante.Id == partido.EquipoVisitante.Id))
        {
            throw new InvalidOperationException("Uno de los equipos ya tiene un partido programado en esta fecha.");
        }

        Partidos.Add(partido);
    }
}