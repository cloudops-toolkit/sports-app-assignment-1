using SportsApi.Models;

namespace SportsApi.Services;

public class SportService : ISportService
{
    private static readonly List<Sport> _sports = new()
    {
        new Sport { Id = 1, Name = "Football", Description = "Most popular sport in America" },
        new Sport { Id = 2, Name = "Basketball", Description = "Fast-paced indoor sport" },
        new Sport { Id = 3, Name = "Baseball", Description = "America's pastime" }
    };

    public async Task<IEnumerable<Sport>> GetAllSports() => 
        await Task.FromResult(_sports);

    public async Task<Sport?> GetSportById(int id) =>
        await Task.FromResult(_sports.FirstOrDefault(s => s.Id == id));
}