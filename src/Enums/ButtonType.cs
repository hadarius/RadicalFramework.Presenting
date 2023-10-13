using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum ButtonType
{
    [Description("button")]
    Button,

    [Description("submit")]
    Submit,

    [Description("reset")]
    Reset
}
