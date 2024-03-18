using DatabaseRelationships.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseRelationships.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Character> characters { get; set; }

        public DbSet<Backpack> backpacks { get; set; }

        public DbSet<Weapon> weapons { get; set; }


    }
}
