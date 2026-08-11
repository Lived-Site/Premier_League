using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories;

public class PartidosRepository
{
    private readonly PremierLeagueContext _context;

    public PartidosRepository(PremierLeagueContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Partido partido)
    {
        await _context.Partidos.AddAsync(partido);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Partido>> GetAllAsync()
    {
        return await _context.Partidos
            .Include(p => p.EquipoLocal)
            .Include(p => p.EquipoVisitante)
            .Include(p => p.Fecha)
            .ToListAsync();
    }

    public async Task<IEnumerable<Partido>> GetByFechaAsync(int fechaId)
    {
        return await _context.Partidos
            .Include(p => p.EquipoLocal)
            .Include(p => p.EquipoVisitante)
            .Include(p => p.Fecha)
            .Where(p => p.FechaId == fechaId)
            .OrderBy(p => p.FechaPartido)
            .ToListAsync();
    }

    public async Task<Partido?> GetByIdAsync(int id)
    {
        return await _context.Partidos
            .Include(p => p.EquipoLocal)
            .Include(p => p.EquipoVisitante)
            .Include(p => p.Fecha)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task UpdateAsync(Partido partido)
    {
        _context.Partidos.Update(partido);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var partido = await _context.Partidos.FindAsync(id);

        if (partido != null)
        {
            _context.Partidos.Remove(partido);
            await _context.SaveChangesAsync();
        }
    }
    
    public async Task<IEnumerable<Partido>> GetByNumeroDeFechaAsync(int numeroDeFecha)
    {
        return await _context.Partidos
            .Include(p => p.EquipoLocal)
            .Include(p => p.EquipoVisitante)
            .Include(p => p.Fecha)
            .Where(p => p.Fecha.NumeroDeFecha == numeroDeFecha)
            .OrderBy(p => p.FechaPartido)
            .ToListAsync();
    }
    
    public async Task<Fecha?> ObtenerFechaPorNumeroAsync(int numeroDeFecha)
    {
        return await _context.Fechas
            .Include(f => f.Partidos)
            .FirstOrDefaultAsync(f => f.NumeroDeFecha == numeroDeFecha);
    }
}