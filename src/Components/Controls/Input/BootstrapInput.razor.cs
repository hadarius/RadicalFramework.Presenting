namespace Radical.Presenting.Components;

public partial class BootstrapInput<TValue>
{
    [Parameter]
    public bool Readonly { get; set; }

    private string? ReadonlyString => Readonly ? "true" : null;
}
