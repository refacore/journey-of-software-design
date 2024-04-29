namespace BubbleSort.Comparer;

public class ComparerFactory : IComparerFactory
{
    public IComparer<T> Create<T>()
    {
        if (typeof(T) == typeof(int))
        {
            return new IntComparer() as IComparer<T>;
        }
        else if (typeof(T) == typeof(string))
        {
            return new StringComparer() as IComparer<T>;
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
