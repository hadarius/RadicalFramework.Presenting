namespace Radical.Presenting.Components;

public partial class BootstrapInputGroup
{
    private string? ClassString => CssBuilder.Default("input-group")
        .AddClassFromAttributes(AdditionalAttributes)
        .Build();

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
