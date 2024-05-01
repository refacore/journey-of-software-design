namespace BubbleSort.Tests;

public class When_sort_by_BubbleSort
{
    [Fact]
    public void With_integer_array_should_return_sorted_array()
    {
        // arrange
        var intArray = new int[] { 3, 4, 2, 1 };

        var expectedArray = new int[] { 1, 2, 3, 4 };

        var command = new BubbleSortCommand();

        command.Numbers = intArray;

        // action
        var result = command.Sort();

        // assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void With_string_array_should_return_sorted_array()
    {
        // arrange
        var stringArray = new string[] { "3", "4", "2", "1" };

        var expectedArray = new string[] { "1", "2", "3", "4" };

        var command = new BubbleSortStringCommand();

        command.Strings = stringArray;

        // action
        var result = command.Sort();

        // assert
        Assert.Equal(expectedArray, result);
    }
}
