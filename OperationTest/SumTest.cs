using Operation;

namespace OperationTest;

public class SumTest
{
    private readonly Sum _sum;
    public SumTest()
    {
        _sum = new Sum();
    }
    [Fact]
    public void Calculate_ValidInputs_ReturnsCorrectSum()
    {
        int a = 10;
        int b = 20;
        int result = _sum.Calculate(a, b);
        Assert.Equal(30, result);
    }

    [Fact]
    public void Calculate_Overflow_ThrowsArgumentException()
    {
        int a = int.MaxValue;
        int b = 1;
        Assert.Throws<ArgumentException>(() => _sum.Calculate(a, b));
    }
}