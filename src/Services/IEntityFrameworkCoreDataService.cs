namespace Radical.Presenting.Components;

public interface IEntityFrameworkCoreDataService
{
    Task CancelAsync();

    Task EditAsync(object model);
}
