using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;

namespace DDDApplication.Domian.Core.Catalogs.Products;

public class ProductFeature
{
    public ProductId ProductId { get; private set; }
    public FeatureId FeatureId { get; private set; }
    public string value { get; private set; }

    private ProductFeature()
    {
    }

    public static ProductFeature CreateProductFeature(ProductId productId, FeatureId featureId, string valuse)
    {
        return new ProductFeature(productId, featureId,valuse);
    }

    public ProductFeature(ProductId productId, FeatureId featureId, string valuse)
    {
        ProductId = productId;
        FeatureId = featureId;
        valuse = valuse;
    }
}