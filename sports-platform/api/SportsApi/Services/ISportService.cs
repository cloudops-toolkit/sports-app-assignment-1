using SportsApi.Models;

namespace SportsApi.Services;

public interface ISportService
{
    Task<IEnumerable<Sport>> GetAllSports();
    Task<Sport?> GetSportById(int id);
}