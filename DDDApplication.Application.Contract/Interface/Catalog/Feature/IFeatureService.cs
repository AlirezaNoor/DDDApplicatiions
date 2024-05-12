 using DDDApplication.Application.Contract.Dto.Catalog.Feature;

namespace DDDApplication.Application.Contract.Interface.Catalog.Feature;

public interface IFeatureService
{
    Task Create(FeatureDto dto);
    Task Edite(FeatureDto dto);
    Task Delete(object id);
    Task<FeatureDto> GetById(object id);
    Task<List<FeatureDto>> GetAll();
}