using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Persistence;

public class MyDbContext : DbContext
{
	public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
	public virtual DbSet<Post> Posts { get; set; }
	public virtual DbSet<Tag> Tags { get; set; }
}
