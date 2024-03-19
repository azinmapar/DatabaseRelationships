using System.Text.Json.Serialization;

namespace DatabaseRelationships.Model
{
    public class Weapon
    {

        public int Id { get; set; }

        public String Name { get; set; } = String.Empty;

        public int CharacterId { get; set; }

        [JsonIgnore]
        public Character Character { get; set; }

    }
}
