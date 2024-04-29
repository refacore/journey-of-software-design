using Microsoft.AspNetCore.Mvc;
using BubbleSort.Bubbles;

public class BubbleSortCommand
{
    [FromQuery]
    public object[] Input { get; set; } = [];

    private readonly IBubbleSortFactory _bubbleSortFactory;

    public BubbleSortCommand(IBubbleSortFactory bubbleSortFactory)
    {
        _bubbleSortFactory = bubbleSortFactory;
    }

    public object[] Sort()
    {
        var bubbleSort = _bubbleSortFactory.Create(Input[0].GetType());

        return bubbleSort.Sort(Input);
    }
}
