using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomework;

public static class CalculateMethods
{
    public static double Add(double x, double y)
    {
        return x + y;
    }
    public static double Minus(double x, double y)
    {
        return x - y;
    }
    public static double LargestNumber(double x, double y)
    {
        if( x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    public static double SmallesNumber(double x, double y)
    {
        if( x > y)
        {
            return y;
        }
        else
        {
            return x;
        }
    }
    public static double Multipy(double x, double y)
    {
        return (x * y);
    }
    public static double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("We can't divide by zero.");
            return 0;
        }
    }
}
