using System.Text.Json.Serialization;

namespace Radical.Presenting.Components;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BreakPoint
{
    None,

    ExtraSmall,

    Small,

    Medium,

    Large,

    ExtraLarge,

    ExtraExtraLarge
}
