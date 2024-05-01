namespace BubbleSort.Comparer;

public class ComparerFactory : IComparerFactory
{
    public IComparer<T> Create<T>()
    {
        if (typeof(T) == typeof(int))
        {
            return (IComparer<T>)new IntComparer();
        }
        else if (typeof(T) == typeof(string))
        {
            return (IComparer<T>)new StringComparer();
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
