using System.Text.Json;
using Moq;

namespace BubbleSort.Tests;

public class When_sort_by_BubbleSort
{
    [Fact]
    public void With_integer_array_should_return_sorted_array()
    {
        // arrange
        var intArray = new int[] { 3, 4, 2, 1 };

        var expectedArray = new int[] { 1 };

        var bubbleSortFactory = MockBubbleSortFactory();

        var command = new BubbleSortCommand(bubbleSortFactory);

        command.Input = JsonSerializer.Serialize(intArray);

        command.DataType = DataType.Integer;

        // act
        var result = command.Sort();

        // assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void With_string_array_should_return_sorted_array()
    {
        // arrange
        var stringArray = new string[] { "3", "4", "2", "1" };

        var expectedArray = new string[] { "1" };

        var bubbleSortFactory = MockBubbleSortFactory();

        var command = new BubbleSortCommand(bubbleSortFactory);

        command.Input = JsonSerializer.Serialize(stringArray);

        command.DataType = DataType.String;

        // act
        var result = command.Sort();

        // assert
        Assert.Equal(expectedArray, result);
    }

    private IBubbleSortFactory MockBubbleSortFactory()
    {
        var mock = new Mock<IBubbleSortFactory>();

        mock.Setup(x => x.Create(It.Is<DataType>(d => d == DataType.Integer))).Returns(MockIntegerSorter());

        mock.Setup(x => x.Create(It.Is<DataType>(d => d == DataType.String))).Returns(MockStringSorter());


        return mock.Object;
    }

    private IBubbleSort MockIntegerSorter()
    {
        var mock = new Mock<IBubbleSort>();

        mock.Setup(x => x.Sort(It.IsAny<string>())).Returns(new int[] { 1 });

        return mock.Object;
    }

    private IBubbleSort MockStringSorter()
    {
        var mock = new Mock<IBubbleSort>();

        mock.Setup(x => x.Sort(It.IsAny<string>())).Returns(new string[] { "1" });

        return mock.Object;
    }
}
