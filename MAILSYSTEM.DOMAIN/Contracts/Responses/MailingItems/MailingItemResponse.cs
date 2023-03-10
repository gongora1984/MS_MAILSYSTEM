using MAILSYSTEM.DOMAIN.Contracts.Responses.MailJobDetails;
using MAILSYSTEM.DOMAIN.Contracts.Responses.MailJobs;

namespace MAILSYSTEM.DOMAIN.Contracts.Responses.MailingItems;

public class MailingItemResponse
{
    public MailJobResponse MailJob { get; set; }

    public AllMailJobDetailReponse MailJobDetails { get; set; }
}
