namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByCategory;

internal class GetListItemByCategoryQueryValidator : AbstractValidator<GetListItemByCategoryQuery>
{
    public GetListItemByCategoryQueryValidator()
    {
        RuleFor(x => x.listItemCategory).NotEmpty().WithMessage("List Item Category is required");
    }
}
