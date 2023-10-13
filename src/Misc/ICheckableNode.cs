namespace Radical.Presenting.Components;

public interface ICheckableNode<TItem> : IExpandableNode<TItem>
{
    CheckboxState CheckedState { get; set; }
}
