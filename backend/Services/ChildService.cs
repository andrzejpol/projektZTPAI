using backend.Entities;
using backend.Models;

namespace backend.Services
{
    public interface IChildService
    {
        IEnumerable<Child> GetChildren();
        void AddChild(Child child);
        Child GetChildById(int id);
        void UpdateChildById(int id, Child child);
        void DeleteChild(int id);
    }
    public class ChildService : IChildService
    {
        private readonly PreschoolDbContext _context;

        public ChildService(PreschoolDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Child> GetChildren()
        {
            var children = _context.Children.ToList();

            return children;
        }

        public void AddChild(Child child) 
        {
            _context.Children.Add(child);
            _context.SaveChanges();
        }

        public Child GetChildById(int id) 
        {
            return _context.Children.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateChildById(int id, Child child) 
        {
            _context.Children.Update(child);
            _context.SaveChanges();
        }
        public void DeleteChild(int id) 
        {
            var child = GetChildById(id);
            if(child != null) 
            {
                _context.Children.Remove(child);
                _context.SaveChanges();
            }
        }
    }
}
