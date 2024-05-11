using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Category;

public class Categories : AggregateRoot<CategoryId>
{
    public string CategoryName { get; private set; }
    public bool IsActive { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyCollection<CategoryFeature> CategoryFeatures => _CategoryFeatures;

    private List<CategoryFeature> _CategoryFeatures => new List<CategoryFeature>();


    private Categories()
    {
    }

    private void buildFeature(List<FeatureId> featureIds)
    {
        featureIds.ForEach(item =>
        {
            var newFeature = CategoryFeature.createCategroyFeature(Id,item);
            _CategoryFeatures.Add(newFeature);
        });
    }

    public static Categories CreatCategory(string categoryName, bool isActive, string description,
        List<FeatureId> featureDatas)
    {
        return new Categories(categoryName, isActive, description, featureDatas);
    }


    public Categories(string categoryName, bool isActive, string description, List<FeatureId> featureDatas)
    {
        CategoryName = categoryName;
        IsActive = isActive;
        Description = description;
        buildFeature(featureDatas);
    }
}