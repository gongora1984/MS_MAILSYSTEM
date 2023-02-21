using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemById;

public sealed record GetListItemByIdQuery(Guid listItemId) : IQuery<ListItemResponse>;
