using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Feature;

public class Feature : AggregateRoot<FeatureId>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int sortCategory { get; private set; }

    
    
    public void FeatureUpdate(string name, string description, int sortCategory)
    {
        Name = name;
        Description = description;
        this.sortCategory = sortCategory;
    }
    public static Feature CreateFeature(string name, string description, int sortCategory)
    {
        return new Feature(name, description, sortCategory);
    }
    public static Feature CreateFeatureUpdate(Guid id, string name, string description, int sortCategory)
    {
        return new Feature(id,name, description, sortCategory);
    }
    public static Feature CreateFeatureForRemove(FeatureId featureId)
    {
        return new Feature(featureId);
    }

    
    
    //constructor For Ef core
    private Feature()
    {
    }



    private Feature(string name, string description, int sortCategory)
    {
        Name = name;
        Description = description;
        this.sortCategory = sortCategory;
    }

    private Feature(Guid id, string name, string description, int sortCategory)
    {
        Id = new FeatureId(id);
        Name = name;
        Description = description;
        this.sortCategory = sortCategory;
    }

    private Feature(FeatureId featureId)
    {
        Id = featureId;
    }


}