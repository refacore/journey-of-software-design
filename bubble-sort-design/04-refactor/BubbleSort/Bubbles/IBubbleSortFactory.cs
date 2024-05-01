namespace BubbleSort.Bubbles;

public interface IBubbleSortFactory
{
    IBubbleSort Create(DataType type);
}
