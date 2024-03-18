namespace DatabaseRelationships.Model
{
    public class Character
    {

        public int Id { get; set; } 

        public String Name { get; set; } = String.Empty;

        public int BackpackId { get; set; }

        public Backpack Backpack { get; set; } = new Backpack();

        public List<Weapon> Weapons { get; set; } = [];
    }
}
