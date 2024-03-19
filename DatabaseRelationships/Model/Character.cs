using System.Text.Json.Serialization;

namespace DatabaseRelationships.Model
{
    public class Character
    {

        public int Id { get; set; } 

        public String Name { get; set; } = String.Empty;

        public int BackpackId { get; set; }

        public Backpack Backpack { get; set; } 

        public List<Weapon> Weapons { get; set; }

        public List<Factions> Factions { get; set; } 
    }
}
