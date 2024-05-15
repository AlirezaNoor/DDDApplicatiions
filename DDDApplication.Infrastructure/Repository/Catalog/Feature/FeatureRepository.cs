using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Infrastructure.Base.Exceptions;
using DDDApplication.Infrastructure.Data.Context;


namespace DDDApplication.Infrastructure.Repository.Catalog.Feature;

public class FeatureRepository : IFeatureRepository
{
    private readonly Contexts Dbcontext;

    public FeatureRepository(Contexts dbcontext)
    {
        Dbcontext = dbcontext;
    }

    public async Task<FeatureId> Insert(Domian.Core.Catalogs.Categories.Feature.Feature feature)
    {
        var result = Domian.Core.Catalogs.Categories.Feature.Feature.CreateFeature(feature.Name, feature.Description,
            feature.sortCategory);
        return result.Id;
    }

    public async Task Update(Domian.Core.Catalogs.Categories.Feature.Feature feature)
    {
        var result = Dbcontext.Features.FirstOrDefault(x => x.Id == feature.Id);
        if (result == null)
        {
            throw new InfraException("your Feature is not valid || we dont find this feature");
        }

        result.FeatureUpdate(feature.Name, feature.Description, feature.sortCategory);
    }

    public async Task<Domian.Core.Catalogs.Categories.Feature.Feature> GetById(FeatureId id)
    {
        return Dbcontext.Features.FirstOrDefault(x => x.Id == id);
    }

    public async Task Delete(FeatureId featureId)
    {
        var Entity=Domian.Core.Catalogs.Categories.Feature.Feature.CreateFeatureForRemove(featureId);
        Dbcontext.Remove(Entity);
    }
}