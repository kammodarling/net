using System.Data.Entity;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("DefaultConnection") { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
}