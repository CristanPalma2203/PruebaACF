using Microsoft.EntityFrameworkCore;
using PruebaUsuarios.Models;

namespace PruebaUsuarios
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
