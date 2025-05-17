namespace MathOperations;

public class SimpleCalculations
{
    public double Adding(double x, double y)
    {
        return x + y;
    }

    public double Minus(double x, double y)
    {
        return x - y;
    }

    public double Highest(double x, double y)
    {
        double output = 0;

        if(x > y)
        {
            output = x;
        }
        else
        {
            output = y;
        }
        return output;
    }
}