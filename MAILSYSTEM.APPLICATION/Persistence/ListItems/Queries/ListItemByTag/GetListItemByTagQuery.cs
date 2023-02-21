using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByTag;

public sealed record GetListItemByTagQuery(string listItemTag) : IQuery<AllListItemResponse>;
