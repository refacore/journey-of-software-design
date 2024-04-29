using Microsoft.AspNetCore.Mvc;

public class BubbleSortString
{
    [FromQuery]
    public string[] Strings { get; set; } = [];

    public string[] Sort()
    {
        var inputLength = Strings.Length;

        for (int i = 0; i < inputLength - 1; i++)
        {
            for (int j = 0; j < inputLength - i - 1; j++)
            {
                if (Strings[j].CompareTo(Strings[j + 1]) > 0)
                {
                    Swap(Strings, j, j + 1);
                }
            }
        }

        return Strings;
    }

    private void Swap(string[] strings, int index, int next)
    {
        var tempVar = strings[index];

        strings[index] = strings[next];

        strings[next] = tempVar;
    }
}
