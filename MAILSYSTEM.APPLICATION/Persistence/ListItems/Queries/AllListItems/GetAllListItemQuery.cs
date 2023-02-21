using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.AllListItems;

public record GetAllListItemQuery : IRequest<AllListItemResponse>;
