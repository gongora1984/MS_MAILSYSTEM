namespace MAILSYSTEM.DOMAIN.Contracts.Requests;

public record MailingItemRequest(MailJobRequest job, MailJobDetailRequest jobDetails);
