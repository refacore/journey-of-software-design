using System.Text.Json;

namespace BubbleSort.Bubbles;

public class IntBubbleSort : IBubbleSort
{
    public object Sort(string input)
    {
        var array = JsonSerializer.Deserialize<int[]>(input);

        if (array == null)
        {
            throw new ArgumentException("input");
        }

        var inputLength = array.Length;

        for (int i = 0; i < inputLength - 1; i++)
        {
            for (int j = 0; j < inputLength - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                }
            }
        }

        return array;
    }

    private void Swap(int[] numbers, int index, int next)
    {
        var tempVar = numbers[index];

        numbers[index] = numbers[next];

        numbers[next] = tempVar;
    }
}
