using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum Size
{
    None,

    [Description("xs")]
    ExtraSmall,

    [Description("sm")]
    Small,

    [Description("md")]
    Medium,

    [Description("lg")]
    Large,

    [Description("xl")]
    ExtraLarge,

    [Description("xxl")]
    ExtraExtraLarge
}
