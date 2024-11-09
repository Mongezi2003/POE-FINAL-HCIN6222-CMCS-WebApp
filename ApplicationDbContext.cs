using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Claim> Claims { get; set; }
    public DbSet<SupportingDocument> SupportingDocuments { get; set; }
    public DbSet<User> Users { get; set; }
}
