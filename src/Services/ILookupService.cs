namespace Radical.Presenting.Components;

public interface ILookupService
{
    IEnumerable<SelectedItem>? GetItemsByKey(string? key);
}
