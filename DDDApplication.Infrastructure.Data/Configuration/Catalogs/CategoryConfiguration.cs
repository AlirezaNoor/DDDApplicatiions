using DDDApplication.Domian.Core.Catalogs.Categories.Category;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDApplication.Infrastructure.Data.Configuration.Catalogs;

public class CategoryConfiguration : IEntityTypeConfiguration<Categories>
{
    public void Configure(EntityTypeBuilder<Categories> builder)
    {
        builder.ToTable("category", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(v => v.GuidValue,
            v => new CategoryId(v)
        );
        builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
        builder.OwnsMany(x => x.CategoryFeatures, s =>
        {
            s.WithOwner().HasForeignKey("CategoryId");
            s.ToTable("CategoryFeature", "Catalog");
            s.Property(x => x.CatgeCategoryId).HasConversion(
                v => v.GuidValue,
                v => new CategoryId(v)
            );
            s.Property(x => x.FeatureId).HasConversion(
                v => v.GuidValue,
                v => new FeatureId(v)
            );
            s.HasKey("CategoryId", "FeatureId");
        });
    }
}