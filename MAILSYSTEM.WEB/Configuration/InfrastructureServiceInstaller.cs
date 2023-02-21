using MAILSYSTEM.INFRASTRUCTURE;
using MAILSYSTEM.INFRASTRUCTURE.Interceptors;
using Microsoft.EntityFrameworkCore;
using Scrutor;

namespace MAILSYSTEM.WEB.Configuration;

public class InfrastructureServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services
            .Scan(
                selector => selector
                    .FromAssemblies(
                        INFRASTRUCTURE.AssemblyReference.Assembly)
                    .AddClasses(false)
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsMatchingInterface()
                    .WithScopedLifetime());

        //// services.AddSingleton<ConvertDomainEventsToOutboxMessagesInterceptor>();

        services.AddSingleton<UpdateAuditableEntitiesInterceptor>();

        services.AddDbContext<ApplicationDbContext>(
            (sp, optionsBuilder) =>
            {
                optionsBuilder.UseSqlServer(
                                    configuration.GetConnectionString("Database"));
            });
    }
}
