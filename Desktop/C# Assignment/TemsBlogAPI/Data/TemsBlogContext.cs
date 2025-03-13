using TemsBlogAPI.Models
using Microsoft.EntityFrameworkCore;

namespace TemsBlogAPI.Data
{
    public class TemsBlogContext : DbContext // ✅ Add : DbContext
    {
        public TemsBlogContext(DbContextOptions<TemsBlogContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
