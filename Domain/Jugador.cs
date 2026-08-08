namespace Domain;

public class Jugador
{
    public int IdJugador { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Nacionalidad { get; set; }
    public string Posicion { get; set; }
    public int Dorsal { get; set; }
    
    
    public Jugador(){}

    public Jugador(string nombre, string apellido, string nacionalidad, string posicion, int dorsal)
    {
        Nombre = nombre;
        Apellido = apellido;
        Nacionalidad = nacionalidad;
        Posicion = posicion;
        Dorsal = dorsal;
    }
}