namespace Radical.Presenting.Components;

internal interface IReconnectorProvider
{
    void Register(Action<RenderFragment?, RenderFragment?, RenderFragment?> action);

    void NotifyContentChanged(IReconnector content);
}
