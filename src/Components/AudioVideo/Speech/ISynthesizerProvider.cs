namespace Radical.Presenting.Components;

public interface ISynthesizerProvider
{
    Task InvokeAsync(SynthesizerOption option);
}
