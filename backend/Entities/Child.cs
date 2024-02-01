using System.Text.RegularExpressions;

namespace backend.Entities
{
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParentId { get; set; }
        public virtual User Parent { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Opinion> Opinions { get; set; }

    }
}
