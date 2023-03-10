namespace MAILSYSTEM.DOMAIN.Contracts.Requests;

public record MailJobRequest(
    string envelopeType,
    string propertyAddress1,
    string? propertyAddress2,
    string propertyCity,
    string propertyState,
    string propertyZip,
    string? customData1,
    string? customData2,
    string? customData3,
    string? envelopeCaption1,
    string? envelopeCaption2,
    string base64Document);
