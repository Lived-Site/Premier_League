namespace Domain;

public class Equipo
{
    public static int IdStatic { get; set; }
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaFundacion { get; set; }
    public string Ciudad { get; set; }
    public string Escudo { get; set; }

    public Equipo(string Nombre, string Descripcion, DateTime FechaFundacion, string Ciudad, string Escudo)
    {
        this.Id = Equipo.IdStatic++;
        this.Nombre = Nombre;
        this.Descripcion = Descripcion;
        this.FechaFundacion = FechaFundacion;
        this.Ciudad = Ciudad;
        this.Escudo = Escudo;
    }
    
    
}