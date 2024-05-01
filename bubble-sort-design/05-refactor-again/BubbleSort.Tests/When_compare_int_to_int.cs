using BubbleSort.Comparer;

public class When_compare_int_to_int
{
    [Fact]
    public void With_bigger_one_should_return_negative_number()
    {
        // arrange
        var comparer = new IntComparer();

        var num = 1;

        var compareNum = 2;

        // act
        var res = comparer.Compare(num, compareNum);

        // assert
        Assert.True(res < 0);
    }

    [Fact]
    public void With_smaller_one_should_return_positive_number()
    {
        // arrange
        var comparer = new IntComparer();

        var num = 2;

        var compareNum = 1;

        // act
        var res = comparer.Compare(num, compareNum);

        // assert
        Assert.True(res > 0);
    }

    [Fact]
    public void With_equal_one_should_return_zero()
    {
        // arrange
        var comparer = new IntComparer();

        var num = 1;

        var compareNum = 1;

        // act
        var res = comparer.Compare(num, compareNum);

        // assert
        Assert.Equal(0, res);
    }
}
