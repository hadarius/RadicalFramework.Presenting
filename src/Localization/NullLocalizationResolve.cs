using Microsoft.Extensions.Localization;

namespace Radical.Presenting.Localization;

internal class NullLocalizationResolve : ILocalizationResolve
{
    public IEnumerable<LocalizedString> GetAllStringsByCulture(bool includeParentCultures) => Enumerable.Empty<LocalizedString>();
}
