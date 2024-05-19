using DDDApplication.Domian.Core.Catalogs.Categories.Category;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Domian.Core.Catalogs.Products;
using DDDApplication.Domian.Core.Customer;
using Microsoft.EntityFrameworkCore;

namespace DDDApplication.Infrastructure.Data.Context;

public class Contexts : DbContext
{
    public Contexts(DbContextOptions<Contexts> options) : base(options)
    {
    }

    public DbSet<product> Products { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Feature> Features { get; set; }
 
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexts).Assembly);
    }
}