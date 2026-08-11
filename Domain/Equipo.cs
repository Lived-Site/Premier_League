namespace Domain;

public class Equipo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateOnly  FechaFundacion { get; set; }
    public string Ciudad { get; set; }
    public string Escudo { get; set; }
    
    public List<Jugador> Jugadores { get; set; }

    public int PartidosJugados { get; set; } = 0;
    
    public int PartidosGanados { get; set; } = 0;
    
    public int PartidosEmpatados { get; set; } = 0;
    
    public int PartidosPerdidos { get; set; } = 0;
    
    
    public int GolesRecibidos { get; set; } = 0;
    
    public int GolesAFavor { get; set; } = 0;

    private Equipo()
    {
    }

    public Equipo(
        string nombre,
        string descripcion,
        DateOnly fechaFundacion,
        string ciudad,
        string escudo)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        FechaFundacion = fechaFundacion;
        Ciudad = ciudad;
        Escudo = escudo;
        Jugadores = new List<Jugador>();
    }

    public void AgregarJugador(Jugador jugador)
    {
        Jugadores.Add(jugador);
    }

    public void QuitarJugador(Jugador jugador)
    {
        Jugadores.Remove(jugador);
    }
}