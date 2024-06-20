using CodeForFun.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeForFun.Data
{
    public class DataContext : IdentityDbContext<User, IdentityRole<long>, long>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Idea> Ideas { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
