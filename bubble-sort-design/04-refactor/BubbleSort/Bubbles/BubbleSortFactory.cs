namespace BubbleSort.Bubbles;

public class BubbleShortFactory : IBubbleSortFactory
{
    public IBubbleSort<T> Create<T>()
    {
        if (typeof(T) is int)
        {
            return new IntBubbleSort() as IBubbleSort<T>;
        }
        else if (typeof(T) is string)
        {
            return new StringBubbleSort() as IBubbleSort<T>;
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
