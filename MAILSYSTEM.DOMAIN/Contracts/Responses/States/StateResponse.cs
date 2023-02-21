namespace MAILSYSTEM.DOMAIN.Contracts.Responses.States;

public class StateResponse
{
    public Guid Id { get; set; }

    public string StateAbbreviation { get; set; } = null!;

    public string StateDescription { get; set; } = null!;
}
