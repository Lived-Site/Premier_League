using Domain;

namespace Service;

public class PartidoService
{
    public void ProgramarPartido(Equipo equipoLocal, Equipo equipoVisitante, DateTime  fecha)
    {
        var partido = new Partido(equipoLocal, equipoVisitante, fecha);
    }
}