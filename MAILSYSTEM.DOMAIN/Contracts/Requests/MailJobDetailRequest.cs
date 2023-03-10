namespace MAILSYSTEM.DOMAIN.Contracts.Requests;

public record MailJobDetailRequest(
    string recipientName,
    string recipientAddress1,
    string? recipientAddress2,
    string recipientCity,
    string recipientState,
    string recipientZip);
