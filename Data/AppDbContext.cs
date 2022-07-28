using GraphQLDotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDotnet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }

}