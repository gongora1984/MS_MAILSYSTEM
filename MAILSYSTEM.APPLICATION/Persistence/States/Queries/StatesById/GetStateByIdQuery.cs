using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesById;

public sealed record GetStateByIdQuery(Guid stateId) : IQuery<StateResponse>;
