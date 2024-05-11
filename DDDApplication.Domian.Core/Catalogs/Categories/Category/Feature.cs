using DDDApplication.Domian.Core.Base;

namespace DDDApplication.Domian.Core.Catalogs.Categories.Category;

public class Feature : Entity<Guid>
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int sortCategory { get; private set; }

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

    public static Feature CreateFeature(string name, string description, int sortCategory)
    {
        return new Feature(name, description, sortCategory);
    }
}