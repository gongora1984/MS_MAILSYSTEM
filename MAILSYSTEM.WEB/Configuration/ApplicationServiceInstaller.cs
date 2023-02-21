using FluentValidation;
using MediatR;

namespace MAILSYSTEM.WEB.Configuration;

public class ApplicationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(APPLICATION.AssemblyReference.Assembly);
        services.AddMediatR(APPLICATION.AssemblyReference.Assembly);

        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(APPLICATION.Behaviors.ValidationPipelineBehavior<,>));

        services.AddValidatorsFromAssembly(
            APPLICATION.AssemblyReference.Assembly,
            includeInternalTypes: true);
    }
}
