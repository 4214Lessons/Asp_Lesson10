using Lesson11MvcAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson11MvcAuth.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
