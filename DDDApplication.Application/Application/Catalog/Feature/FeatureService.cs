using DDDApplication.Application.Contract.Dto.Catalog.Feature;
using DDDApplication.Application.Contract.Interface.Catalog.Feature;

namespace DDDApplication.Application.Application.Catalog.Feature;

public class FeatureService:IFeatureService
{
    public Task Create(FeatureDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edite(FeatureDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Delete(object id)
    {
        throw new NotImplementedException();
    }

    public Task<FeatureDto> GetById(object id)
    {
        throw new NotImplementedException();
    }

    public Task<List<FeatureDto>> GetAll()
    {
        throw new NotImplementedException();
    }
}