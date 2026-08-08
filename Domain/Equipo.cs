namespace Domain;

public class Equipo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateOnly  FechaFundacion { get; set; }
    public string Ciudad { get; set; }
    public string Escudo { get; set; }

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
    }
}