using Microsoft.Extensions.Options;

namespace MAILSYSTEM.WEB.AuthSetup;

public class ApiOptionsSetup : IConfigureOptions<ApiOptions>
{
    private const string SectionName = "Api";
    private readonly IConfiguration _configuration;

    public ApiOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Bind Api configuration from application configuration  file.
    /// </summary>
    /// <param name="options"></param>
    public void Configure(ApiOptions options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}
