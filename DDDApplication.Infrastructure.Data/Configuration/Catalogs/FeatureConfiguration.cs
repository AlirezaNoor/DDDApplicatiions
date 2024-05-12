using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDApplication.Infrastructure.Data.Configuration.Catalogs;

public class FeatureConfiguration:IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.ToTable("Feature", "Catalog");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasConversion(x => x.GuidValue,
            x => new FeatureId(x));
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
        builder.Property(x => x.sortCategory).IsRequired();
    }
}