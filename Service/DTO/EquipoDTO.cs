namespace Service.DTO;

public class EquipoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateOnly FechaFundacion { get; set; }
    public string Ciudad { get; set; }
    public string Escudo { get; set; }
    
    public int PartidosJugados { get; set; } 
    
    public int PartidosGanados { get; set; } 
    
    public int PartidosEmpatados { get; set; } 
    
    public int PartidosPerdidos { get; set; } 
    
    public int GolesRecibidos { get; set; } 
    
    public int GolesAFavor { get; set; } 
    
    public int Posicion { get; set; }
}