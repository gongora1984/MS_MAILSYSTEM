namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByTag;

internal class GetListItemByTagQueryValidator : AbstractValidator<GetListItemByTagQuery>
{
    public GetListItemByTagQueryValidator()
    {
        RuleFor(x => x.listItemTag).NotEmpty().WithMessage("List Item Tag is required");
    }
}
