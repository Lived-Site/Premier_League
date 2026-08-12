using Domain;
using Repository.Repositories;
using Service.DTO;

namespace Service;

public class EquipoService
{
    private readonly EquiposRepository _equiposRepository;
    private readonly PartidosRepository _partidosRepository;

    public EquipoService(EquiposRepository equiposRepository, PartidosRepository partidosRepository)
    {
        _equiposRepository = equiposRepository;
        _partidosRepository = partidosRepository;
    }

    public async Task<IEnumerable<EquipoDTO>> ObtenerTodosAsync()
    {
        var equipos = await _equiposRepository.GetAllAsync();

        return equipos.Select(equipo => new EquipoDTO
        {
            Id = equipo.Id,
            Nombre = equipo.Nombre,
            Descripcion = equipo.Descripcion,
            FechaFundacion = equipo.FechaFundacion,
            Ciudad = equipo.Ciudad,
            Escudo = equipo.Escudo
        });
    }

    public async Task<EquipoDTO?> ObtenerPorIdAsync(int id)
    {
        var equipo = await _equiposRepository.GetByIdAsync(id);

        if (equipo == null)
            return null;

        return new EquipoDTO
        {
            Id = equipo.Id,
            Nombre = equipo.Nombre,
            Descripcion = equipo.Descripcion,
            FechaFundacion = equipo.FechaFundacion,
            Ciudad = equipo.Ciudad,
            Escudo = equipo.Escudo
        };
    }

    public async Task<IEnumerable<EquipoDTO>> ObtenerTablaAsync()
    {
        var equipos = await _equiposRepository.GetAllAsync();
        var partidos = await _partidosRepository.GetAllAsync();

        var tabla = equipos.Select(equipo => new EquipoDTO
        {
            Id = equipo.Id,
            Nombre = equipo.Nombre,
            Descripcion = equipo.Descripcion,
            FechaFundacion = equipo.FechaFundacion,
            Ciudad = equipo.Ciudad,
            Escudo = equipo.Escudo
        }).ToList();

        var partidosFinalizados = partidos.Where(p => p.GolesLocal.HasValue && p.GolesVisitante.HasValue).ToList();

        foreach (var equipo in tabla)
        {
            var partidosEquipo = partidosFinalizados.Where(p =>
                    p.EquipoLocalId == equipo.Id ||
                    p.EquipoVisitanteId == equipo.Id).ToList();

            foreach (var partido in partidosEquipo)
            {
                int golesLocal = partido.GolesLocal!.Value;
                int golesVisitante = partido.GolesVisitante!.Value;

                equipo.PartidosJugados++;

                if (partido.EquipoLocalId == equipo.Id)
                {
                    equipo.GolesAFavor += golesLocal;
                    equipo.GolesRecibidos += golesVisitante;

                    if (golesLocal > golesVisitante)
                    {
                        equipo.PartidosGanados++;
                    }
                    else if (golesLocal == golesVisitante)
                    {
                        equipo.PartidosEmpatados++;
                    }
                    else
                    {
                        equipo.PartidosPerdidos++;
                    }
                }
                else
                {
                    equipo.GolesAFavor += golesVisitante;
                    equipo.GolesRecibidos += golesLocal;

                    if (golesVisitante > golesLocal)
                    {
                        equipo.PartidosGanados++;
                    }
                    else if (golesVisitante == golesLocal)
                    {
                        equipo.PartidosEmpatados++;
                    }
                    else
                    {
                        equipo.PartidosPerdidos++;
                    }
                }
            }
        }

        var tablaOrdenada = tabla
            .OrderByDescending(e => e.PartidosGanados * 3 + e.PartidosEmpatados)
            .ThenByDescending(e => e.GolesAFavor - e.GolesRecibidos)
            .ThenByDescending(e => e.GolesAFavor)
            .ThenBy(e => e.Nombre)
            .ToList();

        for (int i = 0; i < tablaOrdenada.Count; i++)
        {
            tablaOrdenada[i].Posicion = i + 1;
        }

        return tablaOrdenada;
    }

    public IEnumerable<EquipoDTO> ObtenerTablaOrdenada(IEnumerable<EquipoDTO> equipos)
    {
        var tabla = equipos
            .OrderByDescending(e => e.PartidosGanados * 3 + e.PartidosEmpatados)
            .ThenByDescending(e => e.GolesAFavor - e.GolesRecibidos)
            .ThenByDescending(e => e.GolesAFavor)
            .ThenBy(e => e.Nombre)
            .ToList();

        for (int i = 0; i < tabla.Count; i++)
        {
            tabla[i].Posicion = i + 1;
        }

        return tabla;
    }
}
