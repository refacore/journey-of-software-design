public static class ArrayExtensions
{
    public static void Swap<T>(this T[] numbers, int originIndex, int swapIndex)
    {
        var tempVar = numbers[originIndex];

        numbers[originIndex] = numbers[swapIndex];

        numbers[swapIndex] = tempVar;
    }
}
