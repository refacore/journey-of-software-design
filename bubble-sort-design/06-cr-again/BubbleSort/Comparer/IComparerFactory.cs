namespace BubbleSort.Comparer;

public interface IComparerFactory
{
    IComparer<T> Create<T>();
}
