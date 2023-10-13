namespace Radical.Presenting.Components;

public interface IReconnector
{
    RenderFragment? ReconnectingTemplate { get; set; }

    RenderFragment? ReconnectFailedTemplate { get; set; }

    RenderFragment? ReconnectRejectedTemplate { get; set; }
}
