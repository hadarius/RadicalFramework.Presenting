namespace Radical.Presenting.Components;

using Uniques;
using Servitizing.Data.Service.Link;
using Servitizing.Data.Store;

public class OpenDataService<TModel> : DataServiceBase<TModel> where TModel : class, IUniqueIdentifiable, new()
{
    protected ILinkedSet<TModel> _dataSet;

    public OpenDataService(ILinkedSet<IDataStore, TModel> dataSet) { _dataSet = dataSet; }

    public override Task<bool> AddAsync(TModel model) => Task.FromResult(true);

    public override Task<bool> DeleteAsync(IEnumerable<TModel> models) => Task.FromResult(true);

    public override Task<bool> SaveAsync(TModel model, ItemChangedType changedType) => Task.FromResult(true);

    public override Task<QueryData<TModel>> QueryAsync(QueryPageOptions option) => null;
}