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
        Partidos.Add(partido);
    }
}