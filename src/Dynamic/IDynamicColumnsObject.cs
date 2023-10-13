namespace Radical.Presenting.Components;

public interface IDynamicColumnsObject : IDynamicObject
{
    public Dictionary<string, object?> Columns { get; set; }
}
