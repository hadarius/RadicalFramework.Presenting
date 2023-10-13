using Microsoft.Extensions.Localization;

namespace Radical.Presenting.Localization;

public interface ILocalizationResolve
{
    IEnumerable<LocalizedString> GetAllStringsByCulture(bool includeParentCultures);
}
