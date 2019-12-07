using Microsoft.EntityFrameworkCore;

namespace Rpg.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options)
            : base(options)
        {
        }

        public DbSet<CharacterContext> TodoItems { get; set; }
    }
}