namespace Radical.Presenting.Components;

public class FullScreenService : PresenterService<FullScreenOption>
{
    public Task Toggle(FullScreenOption? option = null) => Invoke(option ?? new());
}
