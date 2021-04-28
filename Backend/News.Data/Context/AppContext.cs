using Microsoft.EntityFrameworkCore;
using News.Objects.Models;

namespace News.Data.Context
{
    public class AppContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public AppContext(DbContextOptions<AppContext> options)
        : base(options)
       {
       }
    }
}