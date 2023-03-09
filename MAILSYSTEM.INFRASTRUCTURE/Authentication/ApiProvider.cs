using MAILSYSTEM.DOMAIN.Abstractions;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;

namespace MAILSYSTEM.INFRASTRUCTURE.Authentication;

internal sealed class ApiProvider : IApiProvider
{
    private const string _prefix = "CT-";
    private const int _numberOfSecureBytesToGenerate = 32;
    private const int _lengthOfKey = 36;
    private readonly ApiOptions _apiOptions;
    private readonly ApplicationDbContext _dbContext;
    private readonly IUnitOfWork _unitOfWork;
    public ApiProvider(IOptions<ApiOptions> apiOptions, ApplicationDbContext dbContext, IUnitOfWork unitOfWork)
    {
        _apiOptions = apiOptions.Value;
        _dbContext = dbContext;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Generate Api Key.
    /// </summary>
    /// <param name="company"></param>
    /// <returns></returns>
    public string GenerateApiKey(Company company)
    {
        var expirationInYears = _apiOptions.ApiKeyExpirationYear;
        var accessToken = BuildApiKey();
        var companyLogin = new CompanyLogin
        {
            CompanyId = company.Id,
            CompanyAccessToken = accessToken,
            CompanyAccessTokenValidTo = DateTime.Now.AddYears(expirationInYears),
            CompanyLastAccess = DateTime.UtcNow,
        };

        _dbContext.Set<CompanyLogin>().Add(companyLogin);

        _unitOfWork.SaveChangesAsync();

        return accessToken;
    }

    /// <summary>
    /// Build Api key.
    /// </summary>
    /// <returns></returns>
    private string BuildApiKey()
    {
        var bytes = RandomNumberGenerator.GetBytes(_numberOfSecureBytesToGenerate);

        return string.Concat(_prefix, Convert.ToBase64String(bytes)
            .Replace("/", string.Empty)
            .Replace("+", string.Empty)
            .Replace("=", string.Empty)
            .AsSpan(0, _lengthOfKey - _prefix.Length));
    }
}
