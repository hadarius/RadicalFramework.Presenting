namespace Radical.Presenting.Components;

public interface IRecognizerProvider
{
    Task InvokeAsync(RecognizerOption option);
}
