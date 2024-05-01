namespace BubbleSort.Bubbles;

public class BubbleShortFactory : IBubbleSortFactory
{
    public IBubbleSort Create(DataType type)
    {
        switch (type)
        {
            case DataType.Integer:
                return new IntBubbleSort();

            case DataType.String:
                return new StringBubbleSort();

            default:
                throw new NotImplementedException(type.ToString());
        }
    }
}
