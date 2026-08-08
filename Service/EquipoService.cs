using Domain;
using Repository.Repositories;
using Service.DTO;

namespace Service;

public class EquipoService
{
    private readonly EquiposRepository _equiposRepository;

    public EquipoService(EquiposRepository equiposRepository)
    {
        _equiposRepository = equiposRepository;
    }

    public async Task<IEnumerable<EquipoDto>> ObtenerTodosAsync()
    {
        var equipos = await _equiposRepository.GetAllAsync();

        return equipos.Select(equipo => new EquipoDto
        {
            Id = equipo.Id,
            Nombre = equipo.Nombre,
            Descripcion = equipo.Descripcion,
            FechaFundacion = equipo.FechaFundacion,
            Ciudad = equipo.Ciudad,
            Escudo = equipo.Escudo
        });
    }
    
    public async Task<EquipoDto?> ObtenerPorIdAsync(int id)
    {
        var equipo = await _equiposRepository.GetByIdAsync(id);
        if (equipo == null) return null;

        return new EquipoDto
        {
            Id = equipo.Id,
            Nombre = equipo.Nombre,
            Descripcion = equipo.Descripcion,
            FechaFundacion = equipo.FechaFundacion,
            Ciudad = equipo.Ciudad,
            Escudo = equipo.Escudo
        };
    }
}