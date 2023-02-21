namespace MAILSYSTEM.DOMAIN.Contracts.Requests;

public record RegisterListItemRequest(
    string systemCategory,
    string systemTag,
    string listItemDisplayText,
    int listItemOrder,
    bool? listItemEnable
    );
