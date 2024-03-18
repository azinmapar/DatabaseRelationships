namespace DatabaseRelationships.Model
{
    public class Weapon
    {

        public int Id { get; set; }

        public String Name { get; set; } = String.Empty;

        public int CharacterId { get; set; }

        public Character Character { get; set; } = new Character();

    }
}
