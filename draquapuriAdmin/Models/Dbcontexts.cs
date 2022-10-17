using Microsoft.EntityFrameworkCore;

namespace draquapuriAdmin.Models
{
    public class Dbcontexts : DbContext
    {
        public Dbcontexts(DbContextOptions<Dbcontexts> options) : base(options)
        {

        }

        public DbSet<Login> Login { get; set; } 
    }
}
