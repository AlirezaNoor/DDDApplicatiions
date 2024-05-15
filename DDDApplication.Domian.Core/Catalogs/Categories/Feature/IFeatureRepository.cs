namespace DDDApplication.Domian.Core.Catalogs.Categories.Feature;

public interface IFeatureRepository
{
    Task<FeatureId> Insert(Feature feature);
    Task Update(Feature feature);
    Task<Feature> GetById(FeatureId id);
    Task Delete(FeatureId featureId);
}