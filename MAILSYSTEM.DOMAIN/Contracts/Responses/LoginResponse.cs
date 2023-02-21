using MAILSYSTEM.DOMAIN.Entities;

namespace MAILSYSTEM.DOMAIN.Contracts.Responses;

public class LoginResponse
{
    public string ApiKey { get; set; }

    public bool LoginStatus { get; set; }

    public Company CompanyInformation { get; set; }
}
