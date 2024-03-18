namespace DatabaseRelationships.Model
{
    public class Backpack
    {

        public int Id { get; set; }

        public String Description { get; set; } = String.Empty;

        public Character Character { get; set; } = new Character();

    }
}
