namespace Radical.Presenting.Components;

public interface IFilter
{
    [NotNull]
    IFilterAction? FilterAction { get; set; }
}
