using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum ObjectFitMode
{
    [Description("fill")]
    Fill,

    [Description("contain")]
    Contain,

    [Description("cover")]
    Cover,

    [Description("none")]
    None,

    [Description("scale-down")]
    ScaleDown
}
