namespace BubbleSort.Bubbles;

public interface IBubbleSortFactory
{
    IBubbleSort<T> Create<T>();
}
