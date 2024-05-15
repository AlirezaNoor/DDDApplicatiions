using DDDApplication.Domian.Core.Catalogs.Categories.Feature;
using DDDApplication.Infrastructure.Patterns.Implimantions;
using DDDApplication.Infrastructure.Patterns.interfaces;
using DDDApplication.Infrastructure.Repository.Catalog.Feature;
using Microsoft.Extensions.DependencyInjection;

namespace DDDApplication.Infrastructure.Registreations;

public static class RegistrationsConfig
{
    public static void RegisteraionMethod(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUnitOfWorks,UnitOfWork>();
        serviceCollection.AddScoped<IFeatureRepository,FeatureRepository>();
    }
}