using Microsoft.Extensions.Options;

namespace MAILSYSTEM.WEB.AuthSetup;

public class JwtOptionsSetup : IConfigureOptions<JwtOptions>
{
    private const string SectionName = "Jwt";
    private readonly IConfiguration _configuration;

    public JwtOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Bind Jwt Configuration Section.
    /// </summary>
    /// <param name="options"></param>
    public void Configure(JwtOptions options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}
