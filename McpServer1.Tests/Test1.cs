namespace McpServer1.Tests;

[TestClass]
public sealed class RandomNumberToolsTests
{
    [TestMethod]
    public void GetRandomNumber_DefaultRange_ReturnsValueWithinRange()
    {
        var result = new RandomNumberTools().GetRandomNumber();

        Assert.IsTrue(result is >= 0 and < 100);
    }

    [TestMethod]
    public void GetRandomNumber_CustomRange_ReturnsValueWithinRange()
    {
        var result = new RandomNumberTools().GetRandomNumber(10, 20);

        Assert.IsTrue(result is >= 10 and < 20);
    }

    [TestMethod]
    public void GetRandomNumber_EqualBounds_ReturnsTheBound()
    {
        Assert.AreEqual(5, new RandomNumberTools().GetRandomNumber(5, 5));
    }

    [TestMethod]
    public void GetRandomNumber_ReversedBounds_ThrowsArgumentOutOfRangeException()
    {
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(
            () => new RandomNumberTools().GetRandomNumber(20, 10));
    }
}
