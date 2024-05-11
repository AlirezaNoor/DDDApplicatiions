using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Feature;

public sealed class FeatureId:StronglyTypeid<FeatureId>
{
    public FeatureId(Guid value) : base(value)
    {
    }
}