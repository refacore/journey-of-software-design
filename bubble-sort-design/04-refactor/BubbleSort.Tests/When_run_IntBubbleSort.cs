using System.Text.Json;

public class When_run_IntBubbleSort
{
    [Fact]
    public void With_valid_input_should_return_sorted_array()
    {
        // arrange
        var bubbleSort = new IntBubbleSort();

        var intArray = new int[] { 3, 4, 2, 1 };

        var expectedArray = new int[] { 1, 2, 3, 4 };

        var stringInput = JsonSerializer.Serialize(intArray);

        // act
        var result = bubbleSort.Sort(stringInput);

        // assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void With_null_json_input_should_throw_Exception()
    {
        // arrange
        var bubbleSort = new IntBubbleSort();

        var input = "null";

        // assert
        Assert.Throws<ArgumentException>(() => bubbleSort.Sort(input));
    }
}
