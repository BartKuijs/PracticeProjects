using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

public static class CalculatingMethod
{
    //public static void CalculatingPlus(int n)
    //{
    //    n = n + n;
    //    Console.WriteLine(n);
    //}
    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="n"></param>
    ///// <param name="m"></param>
    //public static void CalculatingMinus(int n, int m) 
    //{ 
    //    n = n - m; 
    //    Console.WriteLine(n); 
    //}
    ///// <summary>
    ///// Calculates n * n
    ///// </summary>
    ///// <param name="n">Number to multiply by itself</param>
    //public static void CalculatingMultiply(int n)
    //{
    //    n = n * n;
    //    Console.WriteLine(n);
    //}

    public static double Add(double x, double y)
    {
        //Console.WriteLine($"The value of {x} + {y} = {x+y}");
        return x + y;
    }

    public static double AddAll(double[] values)
    {
        double result = 0;
        foreach (double value in values)
        {
            result += value;
        }
        return result;
        //Console.WriteLine($"The total is: {result}");
    }

}
