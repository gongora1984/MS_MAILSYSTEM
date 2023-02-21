using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace MAILSYSTEM.WEB.AuthSetup;

public class ApiBearerOptionsSetup : IPostConfigureOptions<AuthenticationSchemeOptions>
{
    private readonly ApiOptions _apiOptions;

    public ApiBearerOptionsSetup(IOptions<ApiOptions> apiOptions)
    {
        _apiOptions = apiOptions.Value;
    }

    public void PostConfigure(string? name, AuthenticationSchemeOptions options)
    {
        ////
    }
}
