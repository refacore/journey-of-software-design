namespace BubbleSort.Comparer;

public interface IComparer<T>
{
    /// <summary>
    /// compare two instance of T
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>1 if x greater, 0 if equals, -1 if smaller</returns>
    int Compare(T x, T y);
}
