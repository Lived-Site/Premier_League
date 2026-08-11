using Domain;
using Repository.Repositories;
using Service.DTO;

namespace Service;

public class PartidoService
{
    private readonly PartidosRepository _partidosRepository;
    private readonly EquiposRepository _equiposRepository;

    public PartidoService(PartidosRepository partidosRepository, EquiposRepository equiposRepository)
    {
        _partidosRepository = partidosRepository;
        _equiposRepository = equiposRepository;
    }

    public async Task ProgramarPartido(int jornada, int equipoLocalId, int equipoVisitanteId, DateTime fechaPartido)
    {
        fechaPartido = fechaPartido.ToUniversalTime();
        var fecha = await _partidosRepository.ObtenerFechaPorNumeroAsync(jornada);

        if (fecha == null)
            throw new InvalidOperationException("La jornada no existe.");

        var equipoLocal = await _equiposRepository.GetByIdAsync(equipoLocalId);

        var equipoVisitante = await _equiposRepository.GetByIdAsync(equipoVisitanteId);

        if (equipoLocal == null)
            throw new InvalidOperationException("El equipo local no existe.");

        if (equipoVisitante == null)
            throw new InvalidOperationException("El equipo visitante no existe.");

        if (equipoLocalId == equipoVisitanteId)
            throw new InvalidOperationException("Un equipo no puede jugar contra sí mismo.");

        var partido = new Partido(fecha, equipoLocal, equipoVisitante, fechaPartido);
        fecha.AgregarPartido(partido);
        await _partidosRepository.AddAsync(partido);
    }

    public async Task<IEnumerable<PartidoDTO>> ObtenerPorJornadaAsync(
        int jornada)
    {
        var partidos = await _partidosRepository
            .GetByNumeroDeFechaAsync(jornada);

        return partidos.Select(partido => new PartidoDTO
        {
            Id = partido.Id,

            EquipoLocalId = partido.EquipoLocal.Id,
            EquipoLocalNombre = partido.EquipoLocal.Nombre,
            EquipoLocalEscudo = partido.EquipoLocal.Escudo,

            EquipoVisitanteId = partido.EquipoVisitante.Id,
            EquipoVisitanteNombre = partido.EquipoVisitante.Nombre,
            EquipoVisitanteEscudo = partido.EquipoVisitante.Escudo,

            GolesLocal = partido.GolesLocal,
            GolesVisitante = partido.GolesVisitante,

            FechaPartido = partido.FechaPartido,

            NumeroDeFecha = partido.Fecha.NumeroDeFecha
        });
    }
    
    
    public async Task RegistrarResultado(
        int partidoId,
        int golesLocal,
        int golesVisitante)
    {
        if (golesLocal < 0 || golesVisitante < 0) throw new InvalidOperationException("Los goles no pueden ser negativos.");

        var partido = await _partidosRepository.GetByIdAsync(partidoId);

        if (partido == null)
            throw new InvalidOperationException("El partido no existe.");

        partido.RegistrarResultado(golesLocal, golesVisitante);

        await _partidosRepository.UpdateAsync(partido);
    }

    public async Task QuitarResultado(int partidoId)
    {
        var partido = await _partidosRepository.GetByIdAsync(partidoId);

        if (partido == null)
            throw new InvalidOperationException("El partido no existe.");

        partido.QuitarResultado();

        await _partidosRepository.UpdateAsync(partido);
    }

    public async Task CancelarPartido(int partidoId)
    {
        var partido = await _partidosRepository.GetByIdAsync(partidoId);

        if (partido == null)
            throw new InvalidOperationException("El partido no existe.");

        await _partidosRepository.DeleteAsync(partidoId);
    }
}