using System.Text.Json;

public class When_run_StringBubbleSort
{
    [Fact]
    public void With_valid_input_should_return_sorted_array()
    {
        // arrange
        var bubbleSort = new StringBubbleSort();

        var stringArray = new string[] { "3", "4", "2", "1" };

        var expectedArray = new string[] { "1", "2", "3", "4" };

        var stringInput = JsonSerializer.Serialize(stringArray);

        // act
        var result = bubbleSort.Sort(stringInput);

        // assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void With_null_json_input_should_throw_Exception()
    {
        // arrange
        var bubbleSort = new StringBubbleSort();

        var input = "null";

        // assert
        Assert.Throws<ArgumentException>(() => bubbleSort.Sort(input));
    }
}
