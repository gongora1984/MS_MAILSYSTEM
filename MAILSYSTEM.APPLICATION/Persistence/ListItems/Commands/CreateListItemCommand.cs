using MAILSYSTEM.DOMAIN.Contracts.Requests;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Commands;

public record CreateListItemCommand(RegisterListItemRequest item) : ICommand<string>;
