using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Category;

public class Categories : AggregateRoot<CategoryId>
{
    public string CategoryName { get; private set; }
    public bool IsActive { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyCollection<Feature> Features => _features;

    private List<Feature> _features => new List<Feature>();


    private Categories()
    {
    }

    private void buildFeature(List<FeatureData> featureDatas)
    {
        featureDatas.ForEach(item =>
        {
            var newFeature = Feature.CreateFeature(item.title, item.Description, item.order);
            _features.Add(newFeature);
        });
    }

    public static Categories CreatCategory(string categoryName, bool isActive, string description,
        List<FeatureData> featureDatas)
    {
        return new Categories(categoryName, isActive, description, featureDatas);
    }


    public Categories(string categoryName, bool isActive, string description, List<FeatureData> featureDatas)
    {
        CategoryName = categoryName;
        IsActive = isActive;
        Description = description;
        buildFeature(featureDatas);
    }
}