public static class ArrayExtensions
{
    public static void Swap(this int[] numbers, int originIndex, int swapIndex)
    {
        var tempVar = numbers[originIndex];

        numbers[originIndex] = numbers[swapIndex];

        numbers[swapIndex] = tempVar;
    }
}
