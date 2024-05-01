using Microsoft.AspNetCore.Mvc;
using BubbleSort.Bubbles;

namespace BubbleSort.Commands;

public class BubbleSortCommand
{
    [FromQuery]
    public string Input { get; set; } = "[]";

    public DataType DataType { get; set; } = DataType.Integer;

    private readonly IBubbleSortFactory _bubbleSortFactory;

    public BubbleSortCommand(IBubbleSortFactory bubbleSortFactory)
    {
        _bubbleSortFactory = bubbleSortFactory;
    }

    public object Sort()
    {
        var bubbleSort = _bubbleSortFactory.Create(this.DataType);

        return bubbleSort.Sort(Input);
    }
}
