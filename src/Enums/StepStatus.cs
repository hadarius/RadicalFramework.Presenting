using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum StepStatus
{
    [Description("wait")]
    Wait,

    [Description("process")]
    Process,

    [Description("finish")]
    Finish,

    [Description("success")]
    Success,

    [Description("error")]
    Error,
}
