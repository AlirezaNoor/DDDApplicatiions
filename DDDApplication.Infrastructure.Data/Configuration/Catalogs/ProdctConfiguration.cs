using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Domian.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDApplication.Infrastructure.Data.Configuration.Catalogs;

internal sealed class ProdctConfiguration : IEntityTypeConfiguration<product>
{
    public void Configure(EntityTypeBuilder<product> builder)
    {
        builder.ToTable("Products", "Cotalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(x => x.GuidValue,
            x => new ProductId(x)
        );
        builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(400);
        builder.Property(x => x.code).IsRequired().HasMaxLength(150);
        builder.OwnsMany(x => x.ProductFeatures, s =>
        {
            s.WithOwner().HasForeignKey("ProductId");
            s.ToTable("ProductFeture", "Catelog");
            s.Property(x => x.FeatureId).HasConversion(x => x.GuidValue,
                x => new FeatureId(x)
            );
            s.Property(x => x.ProductId).HasConversion(x => x.GuidValue,
                x => new ProductId(x)
            );
            s.HasKey("ProductId", "FeaturId");
        });
    }
}