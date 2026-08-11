namespace Domain;

public class Partido
{
    public int Id { get; set; }

    public int FechaId { get; set; }
    public Fecha Fecha { get; set; }

    public int EquipoLocalId { get; set; }
    public Equipo EquipoLocal { get; set; }

    public int EquipoVisitanteId { get; set; }
    public Equipo EquipoVisitante { get; set; }

    public int? GolesLocal { get; set; }
    public int? GolesVisitante { get; set; }

    public DateTime FechaPartido { get; set; }

    private Partido()
    {
    }

    public Partido(
        Fecha fecha,
        Equipo equipoLocal,
        Equipo equipoVisitante,
        DateTime fechaPartido)
    {
        Fecha = fecha;
        FechaId = fecha.Id;

        EquipoLocal = equipoLocal;
        EquipoLocalId = equipoLocal.Id;

        EquipoVisitante = equipoVisitante;
        EquipoVisitanteId = equipoVisitante.Id;

        FechaPartido = fechaPartido;
    }

    public void RegistrarResultado(int golesLocal, int golesVisitante)
    {
        if (golesLocal < 0 || golesVisitante < 0)
            throw new ArgumentException("Los goles no pueden ser negativos.");

        GolesLocal = golesLocal;
        GolesVisitante = golesVisitante;
    }

    public void QuitarResultado()
    {
        GolesLocal = null;
        GolesVisitante = null;
    }
}