namespace Radical.Presenting.Components;

public interface IHandlerException
{
    Task HandlerException(Exception ex, RenderFragment<Exception> errorContent);
}
