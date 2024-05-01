public class When_compare_string_to_string
{
    [Fact]
    public void With_bigger_one_should_return_negative_number()
    {
        // arrange
        var comparer = new BubbleSort.Comparer.StringComparer();

        var str = "1";

        var compareStr = "2";

        // act
        var res = comparer.Compare(str, compareStr);

        // assert
        Assert.True(res < 0);
    }

    [Fact]
    public void With_smaller_one_should_return_positive_number()
    {
        // arrange
        var comparer = new BubbleSort.Comparer.StringComparer();

        var str = "2";

        var compareStr = "1";

        // act
        var res = comparer.Compare(str, compareStr);

        // assert
        Assert.True(res > 0);
    }

    [Fact]
    public void With_equal_one_should_return_zero()
    {
        // arrange
        var comparer = new BubbleSort.Comparer.StringComparer();

        var str = "1";

        var compareStr = "1";

        // act
        var res = comparer.Compare(str, compareStr);

        // assert
        Assert.Equal(0, res);
    }
}
