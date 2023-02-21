using Microsoft.OpenApi.Models;

namespace MAILSYSTEM.WEB.Configuration;

public class PresentationServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        #region COOKIE POLICY CONFIGURATION
        services.AddCookiePolicy(options =>
        {
            // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.None;
        });
        #endregion

        services
            .AddControllers()
            .AddApplicationPart(PRESENTATION.AssemblyReference.Assembly);

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "MAIL SERVICE v1", Version = "v1" });
        });

        #region CONFIGURING CORS
        services.AddCors(options =>
        {
            options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        });
        #endregion
    }
}
