namespace Radical.Presenting.Components;

public class TableCellArgs
{
    [NotNull]
    public object? Row { get; internal set; }

    [NotNull]
    public string? ColumnName { get; internal set; }

    public int Colspan { get; set; }

    public string? Class { get; set; }

    public string? Value { get; set; }
}
