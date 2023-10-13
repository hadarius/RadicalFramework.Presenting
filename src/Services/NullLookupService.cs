namespace Radical.Presenting.Services;

internal class NullLookupService : ILookupService
{
    public IEnumerable<SelectedItem>? GetItemsByKey(string? key) => null;
}
