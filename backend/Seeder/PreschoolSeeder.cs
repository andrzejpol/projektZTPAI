using backend.Entities;

namespace backend.Seeder
{
    public class PreschoolSeeder
    {
        private readonly PreschoolDbContext _dbContext;
        public PreschoolSeeder(PreschoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Preschools.Any())
                {
                    var preschools = GetPreschools();
                    _dbContext.Preschools.AddRange(preschools);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Preschool> GetPreschools()
        {
            var preschools = new List<Preschool>()
            {
                new Preschool()
                {
                    Name = "Zaczarowany Olowek",
                    Description = "Artystyczne przedszkole. Jeśli chcesz aby twoje dziecko przekraczało próg przedszkola z uśmiechem zapisz je do nas.",
                    ContactEmail = "zaczarowany@gmail.com",
                    Address = new Address()
                    {
                        City = "Giebultow",
                        Street = "Orlich Gniazd 30",
                        PostalCode = "32-085",
                        Country = "Polska"
                    }
                },
                new Preschool()
                {
                    Name = "Gumisie",
                    Description = "Dolor sit amet",
                    ContactEmail = "gumisie@gmail.com",
                    Address = new Address()
                    {
                        City = "Krakow",
                        Street = "Powstancow 20",
                        PostalCode = "31-085",
                        Country = "Polska"
                    }
                },
            };

            return preschools;
        }
    }
}
