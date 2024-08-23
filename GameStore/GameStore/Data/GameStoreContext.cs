using GameStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data
{
    public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
        : IdentityDbContext<GameStoreUser>(options)
    {
        public DbSet<Gener> Geners { get; set; }
        public DbSet<Games> Games { get; set; }
    }

  
}
