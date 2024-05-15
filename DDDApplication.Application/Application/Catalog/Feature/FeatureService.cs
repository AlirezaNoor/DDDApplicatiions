using DDDApplication.Application.Contract.Dto.Catalog.Feature;
using DDDApplication.Application.Contract.Interface.Catalog.Feature;
using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Infrastructure.Patterns.interfaces;

namespace DDDApplication.Application.Application.Catalog.Feature;

public class FeatureService : IFeatureService
{
    private readonly IFeatureRepository _featureRepository;
    private readonly IUnitOfWorks _unitOfWorks;

    public FeatureService(IFeatureRepository featureRepository, IUnitOfWorks unitOfWorks)
    {
        _featureRepository = featureRepository;
        _unitOfWorks = unitOfWorks;
    }

    public async Task Create(FeatureDto dto)
    {
        var result =
            Domian.Core.Catalogs.Categories.Feature.Feature.CreateFeature(dto.Name, dto.Description, dto.order);
        _featureRepository.Insert(result);
        _unitOfWorks.SaveChanges();
    }

    public async Task Edite(FeatureDto dto)
    {
        var result=Domian.Core.Catalogs.Categories.Feature.Feature.CreateFeatureUpdate(dto.id, dto.Name, dto.Description,
            dto.order);
        _featureRepository.Update(result);
        _unitOfWorks.SaveChanges();

    }

    public async Task Delete(Guid id)
    {
        _featureRepository.Delete(new FeatureId(id));
        _unitOfWorks.SaveChanges();
    }

    public   async Task<FeatureDto> GetById(Guid id)
    {
        var R=await _featureRepository.GetById(new FeatureId(id));

        return new FeatureDto()
        {
            id = id,
            order = R.sortCategory,
            Description = R.Description,
            Name = R.Name
        };
    }

    public Task<List<FeatureDto>> GetAll()
    {
        throw new NotImplementedException();
    }
}