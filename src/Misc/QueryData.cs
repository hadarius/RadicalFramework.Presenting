namespace Radical.Presenting.Components;

public class QueryData<TItem>
{
    public IEnumerable<TItem>? Items { get; set; }

    public int TotalCount { get; set; }

    public bool IsFiltered { get; set; }

    public bool IsSorted { get; set; }

    public bool IsSearch { get; set; }

    public bool IsAdvanceSearch { get; set; }
}
