namespace BubbleSort.Commands;

public interface ISorter<T>
{
    T[] Sort(T[] input);
}
