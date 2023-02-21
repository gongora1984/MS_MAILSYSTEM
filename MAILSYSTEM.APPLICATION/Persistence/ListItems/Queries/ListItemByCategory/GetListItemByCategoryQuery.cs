using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByCategory;

public sealed record GetListItemByCategoryQuery(string listItemCategory) : IQuery<AllListItemResponse>;
