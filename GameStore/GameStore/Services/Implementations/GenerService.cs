using GameStore.Data;
using GameStore.Models;

namespace GameStore.Services.Implementations;

public class GenerService : IGenerService
{
    public readonly GameStoreContext _dbContext;
    private List<Gener> geners;
    public GenerService(GameStoreContext context)
    {
        _dbContext = context;

        geners.Add(new() { Name = "Action" });
        geners.Add(new() { Name = "Adult" });
        geners.Add(new() { Name = "Family" });
    }

    public Task AddGenerAsync(Gener gener)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGenerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Gener>> GetAllGenersAsync()
    {
        return geners;
    }

    public Task<Gener> GetGenersByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateGenerAsync(int id, Gener gener)
    {
        throw new NotImplementedException();
    }
}
