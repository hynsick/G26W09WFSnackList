using System.ComponentModel.DataAnnotations;

namespace G26W09WFSnackList;

public record Snack(
    string Name,
    string Reason,
    string Image
)
{
    [Key] // (1)
    public int Id { get; init; }

    public override string ToString() => $"[{Name}] {Reason}";
}