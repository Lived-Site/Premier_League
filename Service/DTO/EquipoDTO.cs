namespace Service.DTO;

public class EquipoDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateOnly FechaFundacion { get; set; }
    public string Ciudad { get; set; }
    public string Escudo { get; set; }
}