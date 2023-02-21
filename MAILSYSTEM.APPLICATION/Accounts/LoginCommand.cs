using MAILSYSTEM.APPLICATION.Abstractions.Messaging;

namespace MAILSYSTEM.APPLICATION.Accounts;

public record LoginCommand(string email, string password) : ICommand<string>;
