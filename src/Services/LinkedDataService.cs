using Radical.Presenting.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radical.Presenting.Components;

using Uniques;
using Servitizing.Repository;
using Servitizing.Data.Store;

public class LinkedDataService<TModel> : DataServiceBase<TModel> where TModel : class, IUniqueIdentifiable, new()
{
    protected ILinkedRepository<IDataStore, TModel> _repository;

    public LinkedDataService(ILinkedRepository<IDataStore, TModel> repository) { _repository = repository; }

    public override Task<bool> AddAsync(TModel model) => Task.FromResult(true);

    public override Task<bool> DeleteAsync(IEnumerable<TModel> models) => Task.FromResult(true);

    public override Task<bool> SaveAsync(TModel model, ItemChangedType changedType) => Task.FromResult(true);

    public override Task<QueryData<TModel>> QueryAsync(QueryPageOptions option) => null;
}