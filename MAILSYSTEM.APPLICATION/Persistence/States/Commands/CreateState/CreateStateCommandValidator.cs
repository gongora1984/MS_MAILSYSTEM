namespace MAILSYSTEM.APPLICATION.Persistence.States.Commands.CreateState;

internal class CreateStateCommandValidator : AbstractValidator<CreateStateCommand>
{
    public CreateStateCommandValidator()
    {
        RuleFor(x => x.item.stateDescription).NotEmpty().WithMessage("State name is required").MaximumLength(50).WithMessage("Maximum length for State name is 50 characters.");

        RuleFor(x => x.item.stateAbbreviation).NotEmpty().WithMessage("State Abbreviation is required").MaximumLength(2).WithMessage("Maximum length for State Abbreviation is 2 characters.");
    }
}
