using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Products;

public sealed class ProductId:StronglyTypeid<ProductId>
{
    public ProductId(Guid value) : base(value)
    {
    }
}