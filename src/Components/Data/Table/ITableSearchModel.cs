namespace Radical.Presenting.Components;

public interface ITableSearchModel
{
    IEnumerable<IFilterAction> GetSearchs();

    void Reset();
}
