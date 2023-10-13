using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum FullScreenSize
{
    None,

    [Description("fullscreen")]
    Always,

    [Description("fullscreen-sm-down")]
    Small,

    [Description("fullscreen-md-down")]
    Medium,

    [Description("fullscreen-lg-down")]
    Large,

    [Description("fullscreen-xl-down")]
    ExtraLarge,

    [Description("fullscreen-xxl-down")]
    ExtraExtraLarge
}
