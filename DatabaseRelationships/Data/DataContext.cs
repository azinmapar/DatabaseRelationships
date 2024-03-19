using DatabaseRelationships.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseRelationships.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Character> Characters { get; set; }

        public DbSet<Backpack> Backpacks { get; set; }

        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Factions> Factions { get; set; }


    }
}
