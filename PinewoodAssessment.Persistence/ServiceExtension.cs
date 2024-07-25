using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PinewoodAssessment.Application.Repositories;
using PinewoodAssessment.Persistence.Context;
using PinewoodAssessment.Persistence.Repositories;

namespace PinewoodAssessment.Persistence;

public static class ServiceExtension
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Sqlite");
        services.AddDbContext<UserDbContext>(opt => opt.UseSqlite(connectionString));

        services.AddRepositories();
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services
            .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
            .AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>))
            .AddTransient<IUserRepository, UserRepository>();
    }
}
