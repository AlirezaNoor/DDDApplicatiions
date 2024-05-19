using DDDApplication.Domian.Core.Base;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature.Events;

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
        var fId = new FeatureId(Guid.NewGuid());
        return new Feature(fId, name, description, sortCategory);
    }

    public static Feature CreateFeatureUpdate(Guid id, string name, string description, int sortCategory)
    {
        var fId = new FeatureId(id);
        return new Feature(fId, name, description, sortCategory);
    }

    public static Feature CreateFeatureForRemove(FeatureId featureId)
    {
        return new Feature(featureId);
    }


    //constructor For Ef core
    private Feature()
    {
    }


    private Feature(FeatureId id, string name, string description, int sortCategory)
    {
        Id = id;
        Name = name;
        Description = description;
        this.sortCategory = sortCategory;
        AddDomainEvent(new SendToCustomerEvent(id));
    }

    private Feature(FeatureId featureId)
    {
        Id = featureId;
    }
}