using DDDApplication.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DDDApplication.Api.Configuration;

public static class ApiConfiguration
{
    public static void ApiConfig(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<Contexts>(opt =>
        {
            opt.UseNpgsql(configuration.GetConnectionString("ShopContext"));
        });
    }
}