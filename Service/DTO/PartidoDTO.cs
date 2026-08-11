namespace Service.DTO;

public class PartidoDTO
{
    public int Id { get; set; }

    public int EquipoLocalId { get; set; }
    public string EquipoLocalNombre { get; set; }
    public string EquipoLocalEscudo { get; set; }

    public int EquipoVisitanteId { get; set; }
    public string EquipoVisitanteNombre { get; set; }
    public string EquipoVisitanteEscudo { get; set; }

    public int? GolesLocal { get; set; }
    public int? GolesVisitante { get; set; }

    public DateTime FechaPartido { get; set; }

    public int NumeroDeFecha { get; set; }
}