namespace BubbleSort.Commands;

using BubbleSort.Comparer;

public class StringBubbleSortCommand : BubbleSortCommand<string>
{
    public StringBubbleSortCommand(IComparerFactory comparerFactory) : base(comparerFactory) { }
}
