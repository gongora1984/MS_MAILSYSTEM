namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Commands;

internal class CreateListItemCommandValidator : AbstractValidator<CreateListItemCommand>
{
    public CreateListItemCommandValidator()
    {
        RuleFor(x => x.item.systemCategory).NotEmpty().WithMessage("List Item Category is required").MaximumLength(50).WithMessage("Maximum length for List Item Category is 50 characters.");

        RuleFor(x => x.item.systemTag).NotEmpty().WithMessage("List Item Tag is required").MaximumLength(50).WithMessage("Maximum length for List Item Tag is 50 characters.");

        RuleFor(x => x.item.listItemDisplayText).NotEmpty().WithMessage("List Item Display Text is required").MaximumLength(150).WithMessage("Maximum length for List Item Display Text is 50 characters.");

        RuleFor(x => x.item.listItemOrder).NotEmpty().WithMessage("List Item Order is required");
    }
}
