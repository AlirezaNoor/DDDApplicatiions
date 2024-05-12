using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;

namespace DDDApplication.Domian.Core.Catalogs.Products;

public record class ProductFeature
{

    public  ProductId  ProductId{ get;   init; }
    public FeatureId  FeatureId { get;   init; }

    private  ProductFeature()
    {
        
    }

    public static ProductFeature CreateProductFeature(ProductId productId, FeatureId featureId)
    {
        return new ProductFeature(productId, featureId);
    }

    public ProductFeature(ProductId productId, FeatureId featureId)
    {
        ProductId = productId;
        FeatureId = featureId;
    }
}