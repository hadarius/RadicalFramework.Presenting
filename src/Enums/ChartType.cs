using System.ComponentModel;

namespace Radical.Presenting.Components;

public enum ChartType
{
    [Description("line")]
    Line = 0,

    [Description("bar")]
    Bar,

    [Description("pie")]
    Pie,

    [Description("doughnut")]
    Doughnut,

    [Description("bubble")]
    Bubble
}
