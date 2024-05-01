using System.Text.Json;

namespace BubbleSort.Bubbles;

public class StringBubbleSort : IBubbleSort
{
    public object Sort(string input)
    {
        var array = JsonSerializer.Deserialize<string[]>(input);

        if (array == null)
        {
            throw new ArgumentException("input");
        }

        var inputLength = array.Length;

        for (int i = 0; i < inputLength - 1; i++)
        {
            for (int j = 0; j < inputLength - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Swap(array, j, j + 1);
                }
            }
        }

        return array;
    }

    private void Swap(string[] strings, int index, int next)
    {
        var tempVar = strings[index];

        strings[index] = strings[next];

        strings[next] = tempVar;
    }
}
