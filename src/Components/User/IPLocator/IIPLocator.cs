namespace Radical.Presenting.Components;

public interface IIPLocator
{
    Task<string?> Locate(IPLocatorOption option);

    public string? Url { get; set; }
}
