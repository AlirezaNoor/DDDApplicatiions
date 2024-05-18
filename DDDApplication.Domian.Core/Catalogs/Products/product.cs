using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Domian.Core.Catalogs.Products.Event;
using DDDApplication.Domian.Core.Sherad;

namespace DDDApplication.Domian.Core.Catalogs.Products;

public class product : AggregateRoot<ProductId>
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string code { get; private set; }
    public double price { get; private set; }
    private List<ProductFeature> _productFeatures = new List<ProductFeature>();
    public IReadOnlyList<ProductFeature> ProductFeatures => _productFeatures;

    public void BuidldFeature(List<ProductFeatureData> featureIds)
    {
        featureIds.ForEach(x =>
        {
            var newFeature = ProductFeature.CreateProductFeature(x.ProductId,x.FeatureId,x.value);
        });
    }


    public static product Createproduct(string title, string description, string code, double price,
        List<ProductFeatureData> FId)
    {
        return new product(title, description, code, price, FId);
    }


    private product()
    {
    }

    public product(string title, string description, string code, double price, List<ProductFeatureData> FId)
    {
        Title = title;
        Description = description;
        this.code = code;
        this.price = price;
        BuidldFeature(FId);
        AddDomainEvent(new SendToCustomerEvent(Id)) ;
    }
}