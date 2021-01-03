using Contact.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Conttact> Contacts { get; set; }
    }
}