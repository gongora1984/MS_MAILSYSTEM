using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.AllStates;

public record GetAllStateQuery : IRequest<AllStateResponse>;
