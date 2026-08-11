namespace Domain;

public class Partido
{
    public int Id { get; set; }
    public Equipo EquipoLocal { get; set; }
    public Equipo EquipoVisitante { get; set; }
    public int GolesLocal { get; set; }
    public int GolesVisitante { get; set; }
    public DateTime Fecha { get; set; }

    public Partido()
    {
    }
    
    public Partido(Equipo equipoLocal, Equipo equipoVisitante, DateTime fecha)
    {
        EquipoLocal = equipoLocal;
        EquipoVisitante = equipoVisitante;
        Fecha = fecha;
    }
    
    public void GolesDelLocal(int golesLocal)
    {
        GolesLocal = golesLocal;
    }
    
    public void GolesDelVisitante(int golesVisitante)
    {
        GolesVisitante = golesVisitante;
    }
}