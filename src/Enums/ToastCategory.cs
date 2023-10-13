using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum ToastCategory
{
    [Description("success")]
    Success,

    [Description("info")]
    Information,

    [Description("danger")]
    Error,

    [Description("warning")]
    Warning
}
