using MAILSYSTEM.DOMAIN.Contracts.Requests;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Commands.CreateState;

public record CreateStateCommand(RegisterStateRequest item) : ICommand<string>;
