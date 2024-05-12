using DDDApplication.Domian.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDApplication.Infrastructure.Data.Configuration.Catalogs;

internal sealed class ProdctConfiguration:IEntityTypeConfiguration<product>
{
    public void Configure(EntityTypeBuilder<product> builder)
    {
        builder.ToTable("Products", "Cotalog");
        builder.HasKey(x => x.Id);
        
    }
}