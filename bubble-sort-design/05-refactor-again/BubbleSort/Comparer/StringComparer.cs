namespace BubbleSort.Comparer;

public class StringComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return x.CompareTo(y);
    }
}
