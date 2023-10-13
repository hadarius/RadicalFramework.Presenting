namespace Radical.Presenting.Components;

public interface IIPLocatorProvider
{
    Task<string?> Locate(string ip);
}
