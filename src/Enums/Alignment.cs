using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum Alignment
{
    None,

    [Description("start")]
    Left,

    [Description("center")]
    Center,

    [Description("end")]
    Right
}
