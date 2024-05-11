using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Category;

public class CategoryFeature : Entity<Guid>
{
    public CategoryId CatgeCategoryId { get; set; }
    public FeatureId FeatureId { get; set; }

    public static CategoryFeature createCategroyFeature(CategoryId catgeCategoryId, FeatureId featureId)

    {
        return new CategoryFeature(catgeCategoryId, featureId);
    }

    private CategoryFeature()
    {
    }


    private CategoryFeature(CategoryId catgeCategoryId, FeatureId featureId)
    {
        CatgeCategoryId = catgeCategoryId;
        FeatureId = featureId;
    }
}