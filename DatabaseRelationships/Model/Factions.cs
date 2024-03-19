using System.Text.Json.Serialization;

namespace DatabaseRelationships.Model
{
    public class Factions
    {

        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        [JsonIgnore]
        public List<Character> Character { get; set; } 



    }
}
