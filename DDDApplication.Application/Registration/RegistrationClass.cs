using System.Reflection;
using DDDApplication.Application.Application.Catalog.Feature;
using DDDApplication.Application.Contract.Interface.Catalog.Feature;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DDDApplication.Application.Registration;

public static class RegistrationClass
{
    public static void RegistrationMethod(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IFeatureService, FeatureService>();
        serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
    }
}