namespace MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

public class ListItemResponse
{
    public Guid Id { get; set; }

    public string SystemCategory { get; set; } = null!;

    public string SystemTag { get; set; } = null!;

    public string ListItemDisplayText { get; set; } = null!;

    public int ListItemOrder { get; set; }

    public bool? ListItemEnable { get; set; }
}
