namespace backend.Entities
{
    public class Opinion
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateAdded { get; set; }
        public int ChildId { get; set; }
        public virtual Child Child { get; set; }
    }
}
