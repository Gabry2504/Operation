namespace Operation;
public class Sum
{
    public int Calculate(int a, int b)
    {
        try
        {
            checked
            {
                return a + b;
            }
        }
        catch (OverflowException)
        {
            throw new ArgumentException("The result exceeds the allowed range for integers.");
        }
    }
}