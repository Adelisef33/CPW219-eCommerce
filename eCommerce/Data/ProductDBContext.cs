using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data

public class ProductDBContext : DBContext
{
    public ProductDBContext(DbContextOptions options) : base(options)
    {
    }

    // Entities to be tracked by DBContext
    public DbSet<Product> Products { get; set; }
}

