using Repository.Context;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories;

public class EquiposRepository
{
    private readonly PremierLeagueContext _context;

    public EquiposRepository(PremierLeagueContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Equipo team)
    {
        await _context.Equipos.AddAsync(team);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Equipo>> GetAllAsync()
    {
        return await _context.Equipos.ToListAsync();
    }

    public async Task<Equipo?> GetByIdAsync(Guid id)
    {
        return await _context.Equipos.FindAsync(id);
    }

    public async Task UpdateAsync(Equipo team)
    {
        _context.Equipos.Update(team);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var team = await _context.Equipos.FindAsync(id);

        if (team != null)
        {
            _context.Equipos.Remove(team);
            await _context.SaveChangesAsync();
        }
    }
}