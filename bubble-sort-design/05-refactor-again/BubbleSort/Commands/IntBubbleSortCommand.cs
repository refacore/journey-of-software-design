namespace BubbleSort.Commands;

using BubbleSort.Comparer;

public class IntBubbleSortCommand : BubbleSortCommand<int>
{
    public IntBubbleSortCommand(IComparerFactory comparerFactory) : base(comparerFactory) { }
}
