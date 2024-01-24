namespace backend.Entities
{
    public class Preschool
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ContactEmail { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
