using GameStore.Models;

namespace GameStore.Services;

public interface IGenerService
{
    Task<IEnumerable<Gener>> GetAllGenersAsync();
    Task<Gener> GetGenersByIdAsync(int id);
    Task AddGenerAsync(Gener gener);
    Task UpdateGenerAsync(int id, Gener gener);

    Task DeleteGenerAsync(int id);
}
