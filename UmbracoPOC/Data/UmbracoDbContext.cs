using Microsoft.EntityFrameworkCore;
using UmbracoPOC.Models;

namespace UmbracoPOC.Data
{
    public class UmbracoDbContext : DbContext
    {

        public UmbracoDbContext(DbContextOptions<UmbracoDbContext> options) : base(options)
        {
        }


        public DbSet<Models.Movie> Movies { get; set; }

    }
}
