using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace MAILSYSTEM.INFRASTRUCTURE.Authentication.Middlewares;

public class ApiKeyAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly ApiOptions _apiOptions;
    private readonly ApplicationDbContext _context;

    public ApiKeyAuthenticationHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock,
        IOptions<ApiOptions> apiOptions,
        ApplicationDbContext context)
        : base(options, logger, encoder, clock)
    {
        _apiOptions = apiOptions.Value;
        _context = context;
    }

    public string ApiKeyHeaderHandler { get; set; }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        ApiKeyHeaderHandler = _apiOptions.ApiKeyHeaderName;

        if (!Request.Headers.ContainsKey(ApiKeyHeaderHandler))
        {
            return AuthenticateResult.Fail("Header Not Found.");
        }

        var apiKeyToValidate = Request.Headers[ApiKeyHeaderHandler];

        var companyLogin = await _context.Set<CompanyLogin>()
                .Include(uak => uak.Company)
                .SingleOrDefaultAsync(uak => uak.CompanyAccessToken == apiKeyToValidate.ToString());

        if (companyLogin == null)
        {
            return AuthenticateResult.Fail("Invalid key.");
        }

        if ((companyLogin.CreatedOnUtc.Date - DateTime.UtcNow.Date).Minutes > Convert.ToInt32(_apiOptions.ApiKeyExpirationMinutes))
        {
            return AuthenticateResult.Fail("Api key expired. Please re-authenticate");
        }

        return AuthenticateResult.Success(CreateTicket(companyLogin.Company));
    }

    private AuthenticationTicket CreateTicket(Company company)
    {
        var claims = new[]
        {
                new Claim(ClaimTypes.NameIdentifier, company.Id.ToString()),
                new Claim(ClaimTypes.Name, company.CompanyName),
                new Claim(ClaimTypes.Email, company.CompanyUsername)
        };

        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return ticket;
    }
}
