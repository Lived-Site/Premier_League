using Repository.Repositories;
using Service.DTO;

namespace Service;

public class JugadorService
{
    private readonly EquiposRepository _equiposRepository;

    public JugadorService(EquiposRepository equiposRepository)
    {
        _equiposRepository = equiposRepository;
    }

    public async Task<IEnumerable<JugadorDTO>> ObtenerTodosAsync()
    {
        var equipos = await _equiposRepository.GetAllAsync();

        return equipos
            .SelectMany(e => e.Jugadores, (equipo, jugador) => new JugadorDTO
            {
                Id = jugador.Id,
                Nombre = jugador.Nombre,
                Apellido = jugador.Apellido,
                Nacionalidad = jugador.Nacionalidad,
                Posicion = jugador.Posicion,
                Dorsal = jugador.Dorsal,
            });
    }

    public async Task<IEnumerable<JugadorDTO>> ObtenerPorEquipoAsync(int equipoId)
    {
        var equipo = await _equiposRepository.GetByIdAsync(equipoId);

        if (equipo is null)
            return Enumerable.Empty<JugadorDTO>();

        return equipo.Jugadores.Select(jugador => new JugadorDTO
        {
            Id = jugador.Id,
            Nombre = jugador.Nombre,
            Apellido = jugador.Apellido,
            Nacionalidad = jugador.Nacionalidad,
            Posicion = jugador.Posicion,
            Dorsal = jugador.Dorsal,
        });
        
    }
}