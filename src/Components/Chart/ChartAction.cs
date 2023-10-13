using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum ChartAction
{
    [Description("update")]
    Update,

    [Description("addDataset")]
    AddDataset,

    [Description("removeDataset")]
    RemoveDataset,

    [Description("addData")]
    AddData,

    [Description("removeData")]
    RemoveData,

    [Description("setAngle")]
    SetAngle,

    [Description("reload")]
    Reload
}
