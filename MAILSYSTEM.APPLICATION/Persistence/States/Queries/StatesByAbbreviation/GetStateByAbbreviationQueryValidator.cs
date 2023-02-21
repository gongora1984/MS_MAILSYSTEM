namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByAbbreviation;

internal class GetStateByAbbreviationQueryValidator : AbstractValidator<GetStateByAbbreviationQuery>
{
    public GetStateByAbbreviationQueryValidator()
    {
        RuleFor(x => x.abbreviation).NotEmpty().WithMessage("State Abbreviation is required");
    }
}
