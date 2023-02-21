namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByName;

internal class GetStateByNameQueryValidator : AbstractValidator<GetStateByNameQuery>
{
    public GetStateByNameQueryValidator()
    {
        RuleFor(x => x.name).NotEmpty().WithMessage("State Name is required");
    }
}
