using Microsoft.AspNetCore.Mvc;

public class BubbleSort
{
    [FromQuery]
    public int[] Numbers { get; set; } = [];

    public int[] Sort()
    {
        var inputLength = Numbers.Length;

        for (int i = 0; i < inputLength - 1; i++)
        {
            for (int j = 0; j < inputLength - i - 1; j++)
            {
                if (Numbers[j] > Numbers[j + 1])
                {
                    Swap(Numbers, j, j + 1);

                    // Numbers.Swap(j, j + 1);
                }
            }
        }

        return Numbers;
    }

    private void Swap(int[] numbers, int index, int next)
    {
        var tempVar = Numbers[index];

        Numbers[index] = Numbers[next];

        Numbers[next] = tempVar;
    }
}
