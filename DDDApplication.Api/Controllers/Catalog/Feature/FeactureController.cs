using DDDApplication.Application.Contract.Dto.Catalog.Feature;
using DDDApplication.Application.Contract.Interface.Catalog.Feature;
using Microsoft.AspNetCore.Mvc;

namespace DDDApplication.Api.Controllers.Catalog.Feature;

public class FeactureController : BasicController
{
    private readonly IFeatureService _featureService;

    public FeactureController(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    [HttpPost("createFeature")]
    public async Task<IActionResult> CreateFeature(FeatureDto dto)
    {
        _featureService.Create(dto);
        return Ok();
    }
}