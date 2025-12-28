using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Persistance.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Blogy> Blogs { get; set; }
    public DbSet<ContactInfo> ContactInfos { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Social> Socials { get; set; }
}
