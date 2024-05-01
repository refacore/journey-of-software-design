using Moq;
using BubbleSort.Comparer;

namespace BubbleSort.Tests;

public class When_sort_by_BubbleSort
{
    [Fact]
    public void With_integer_array_should_return_sorted_array()
    {
        // arrange
        var intArray = new int[] { 3, 4, 2, 1 };

        var expectedArray = new int[] { 1, 2, 3, 4 };

        var command = new IntBubbleSortCommand(MockComparerFactory());

        // action
        var result = command.Sort(intArray);

        // assert
        Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void With_string_array_should_return_sorted_array()
    {
        // arrange
        var stringArray = new string[] { "3", "4", "2", "1" };

        var expectedArray = new string[] { "1", "2", "3", "4" };

        var command = new StringBubbleSortCommand(MockComparerFactory());

        // action
        var result = command.Sort(stringArray);

        // assert
        Assert.Equal(expectedArray, result);
    }

    private IComparerFactory MockComparerFactory()
    {
        var mock = new Mock<IComparerFactory>();

        mock.Setup(x => x.Create<int>()).Returns(MockIntComparer());

        mock.Setup(x => x.Create<string>()).Returns(MockStringComparer());

        return mock.Object;
    }

    private BubbleSort.Comparer.IComparer<int> MockIntComparer()
    {
        var mock = new Mock<BubbleSort.Comparer.IComparer<int>>();

        mock.Setup(x => x.Compare(It.IsAny<int>(), It.IsAny<int>())).Returns((int x, int y) => x - y);

        return mock.Object;
    }

    private BubbleSort.Comparer.IComparer<string> MockStringComparer()
    {
        var mock = new Mock<BubbleSort.Comparer.IComparer<string>>();

        mock.Setup(x => x.Compare(It.IsAny<string>(), It.IsAny<string>())).Returns((string x, string y) => x.CompareTo(y));

        return mock.Object;
    }
}
