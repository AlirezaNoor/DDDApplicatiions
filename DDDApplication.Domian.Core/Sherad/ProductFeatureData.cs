using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Domian.Core.Catalogs.Products;

namespace DDDApplication.Domian.Core.Sherad;

public record class ProductFeatureData
{
    public ProductId ProductId { get; init; }
    public FeatureId FeatureId { get; init; }
    public string value { get; init; }
}