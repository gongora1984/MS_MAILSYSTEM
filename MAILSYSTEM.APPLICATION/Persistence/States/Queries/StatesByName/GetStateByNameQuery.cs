using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByName;

public sealed record GetStateByNameQuery(string name) : IQuery<StateResponse>;
