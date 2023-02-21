using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByAbbreviation;

public sealed record GetStateByAbbreviationQuery(string abbreviation) : IQuery<StateResponse>;
