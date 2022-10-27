using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int n = 5;
        int p = 3;

        int expected = 1;
        int actual = Result.pageCount(n, p);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        int n = 6;
        int p = 2;

        int expected = 1;
        int actual = Result.pageCount(n, p);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        int n = 7;
        int p = 4;

        int expected = 1;
        int actual = Result.pageCount(n, p);

        Assert.Equal(expected, actual);
    }
}