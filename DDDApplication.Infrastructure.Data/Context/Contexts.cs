using DDDApplication.Domian.Core.Catalogs.Categories.Category;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Domian.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;

namespace DDDApplication.Infrastructure.Data.Context;

public class Contexts : DbContext
{
    public Contexts(DbContextOptions options) : base(options)
    {
    }

    public DbSet<product> Products { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Feature> Features { get; set; }
}